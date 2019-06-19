using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoogleAuthenticator
{
    class Program
    {
        static void Main(string[] args)
        {
            long duration = 30;
            string key = "xeon997@foxmail.com";
            GoogleAuthenticator authenticator = new GoogleAuthenticator(duration, key);
            var mobileKey = authenticator.GetMobilePhoneKey();

            while (true)
            {

                Console.WriteLine("手机端秘钥为：" + mobileKey);

                var code = authenticator.GenerateCode();
                Console.WriteLine("动态验证码为：" + code);

                Console.WriteLine("刷新倒计时：" + authenticator.EXPIRE_SECONDS);

                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
