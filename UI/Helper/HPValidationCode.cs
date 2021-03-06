﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace UI.Helper
{
    public class HPValidationCode
    {
        Bitmap image;
        Graphics graphics;
        Random random = new Random();
        int sum;
        public string verificationCode = "";
        public byte[] GetImgByte()
        {
            verificationCode = GetValidateCode();
            //先生成位图
            image = GetBitmap();
            //生成画线的次数
            //画线
            DrawLine();
            //画点
            DrawPoints();
            ////生成字符串 并 画线
            DrawText();
            MemoryStream stream = new MemoryStream();
            image.Save(stream, ImageFormat.Jpeg);
            return stream.ToArray();
        }
        //生成位图
        public Bitmap GetBitmap()
        {
            image = new Bitmap(53, 22);

            graphics = Graphics.FromImage(image);
            random = new Random();
            graphics.Clear(Color.White);
            sum = random.Next(1, 6);
            return image;

        }
        public string GetValidateCode()
        {
            return verificationCode = Encoding.ASCII.GetString(
                        new byte[] {
                     (byte)random.Next(97, 122),
                     (byte)random.Next(65, 90),
                     (byte)random.Next(48, 57),
                     (byte)random.Next(97, 122)});
        }
        //设置画线几条
        public void drawLines()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"in drawLines():{i}");
                DrawLine();
            }
        }
        //画线
        public void DrawLine()
        {
            Pen pen = new Pen(
                Color.FromArgb(random.Next(255),
                random.Next(255),
                random.Next(255)));
            Point x = new Point(
                random.Next(0, 22),
                random.Next(0, 22));
            Point y = new Point(
                random.Next(0, 22),
                random.Next(0, 22));
            graphics.DrawLine(pen, x, y);

        }
        //画点
        public void DrawPoints()
        {
            for (int i = 0; i < 100; i++)
            {
                //画点
                image.SetPixel(random.Next(53), random.Next(22), Color.FromArgb(random.Next(9999)));
            }
        }
        //生成验证码,并画出来。
        public void DrawText()
        {
            for (int i = 0; i < verificationCode.Length; i++)
            {
                //画字符串。
                graphics.DrawString(verificationCode[i].ToString(),
                    new Font("宋体", 17, FontStyle.Bold),
                    new SolidBrush(
                     Color.DarkRed),
                    new PointF(i * 12 + 2, 0));
            }
        }
    }
}
