using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohnnysCoffeeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void CalculateFunction_Click(object sender, EventArgs e)
        {
            Decimal BRA340 = 0;
            Decimal BRA1000 = 0;
            Decimal BRAXG = 0;
            Decimal BRATotal = 0;
            Decimal BRATotal340 = 0;

            Decimal BALI340 = 0;
            Decimal BALI1000 = 0;
            Decimal BALIXG = 0;
            Decimal BALITotal = 0;
            Decimal BALITotal340 = 0;

            Decimal COSTA340 = 0;
            Decimal COSTA1000 = 0;
            Decimal COSTAXG = 0;
            Decimal COSTATotal = 0;
            Decimal COSTATotal340 = 0;

            Decimal ETHO340 = 0;
            Decimal ETHO1000 = 0;
            Decimal ETHOXG = 0;
            Decimal ETHOTotal = 0;
            Decimal ETHOTotal340 = 0;

            Decimal SC340 = 0;
            Decimal SC1000 = 0;
            Decimal SCXG = 0;
            Decimal SCTotal = 0;
            Decimal SCTotal340 = 0;

            Decimal TRADE340 = 0;
            Decimal TRADE1000 = 0;
            Decimal TRADEXG = 0;
            Decimal TRADETotal = 0;
            Decimal TRADETotal340 = 0;

            //BRAZIL -
            if (Brazil340.Text != "")
            {
                BRA340 = Convert.ToDecimal(Brazil340.Text) * 340;
            }

            if (Brazil1000.Text != "")
            {
                BRA1000 = Convert.ToDecimal(Brazil1000.Text) * 1000;
            }
             
            if (BrazilXG.Text != "")
            {
                BRAXG = Convert.ToDecimal(BrazilXG.Text);
            }
            //BRAZIL +

            //BALI -
            if (Bali340.Text != "")
            {
                BALI340 = Convert.ToDecimal(Bali340.Text) * 340;
            }
            if (Bali1000.Text != "")
            {
                BALI1000 = Convert.ToDecimal(Bali1000.Text) * 1000;
            }
            if (BaliXG.Text != "")
            {
                BALIXG = Convert.ToDecimal(BaliXG.Text);
            }
            //BALI +

            //COSTA -
            if (Costa340.Text != "")
            {
                COSTA340 = Convert.ToDecimal(Costa340.Text) * 340;
            }
            if (Costa1000.Text != "")
            {
                COSTA1000 = Convert.ToDecimal(Costa1000.Text) * 1000;
            }
            if (CostaXG.Text != "")
            {
                COSTAXG = Convert.ToDecimal(CostaXG.Text);
            }
            //COSTA +
            
            //ETHO -
            if (Ethopian340.Text != "")
            {
                ETHO340 = Convert.ToDecimal(Ethopian340.Text) * 340;
            }
            if (Ethopian1000.Text != "")
            {
                ETHO1000 = Convert.ToDecimal(Ethopian1000.Text) * 1000;
            }
            if (EthopianXG.Text != "")
            {
                ETHOXG = Convert.ToDecimal(EthopianXG.Text);
            }
            //ETHO +

            //SC -
            if (SouthCendral340.Text != "")
            {
                SC340 = Convert.ToDecimal(SouthCendral340.Text) * 340;
            }
            if (SouthCendral1000.Text != "")
            {
                SC1000 = Convert.ToDecimal(SouthCendral1000.Text) * 1000;
            }
            if (SouthCendralXG.Text != "")
            {
                SCXG = Convert.ToDecimal(SouthCendralXG.Text);
            }
            //SC +

            //TRADEWINDS -
            if (Tradewinds340.Text != "")
            {
                TRADE340 = Convert.ToDecimal(Tradewinds340.Text) * 340;
            }
            if (Tradewinds1000.Text != "")
            {
                TRADE1000 = Convert.ToDecimal(Tradewinds1000.Text) * 1000;
            }
            if (TradewindsXG.Text != "")
            {
                TRADEXG = Convert.ToDecimal(TradewindsXG.Text);
            }
            //TRADEWINDS +

            //Calculate -

            SCTotal = SC340 + SC1000 + SCXG;
            SCTotal340 = SCTotal / 340;

            TRADETotal = TRADE340 + TRADE1000 + TRADEXG;
            TRADETotal340 = TRADETotal / 340;

            BRATotal = BRA340 + BRA1000 + BRAXG + ((decimal)SCTotal * (decimal)0.5);
            BRATotal340 = BRATotal / 340;

            BALITotal = BALI340 + BALI1000 + BALIXG + ((decimal)TRADETotal * (decimal)0.5);
            BALITotal340 = BALITotal / 340;

            COSTATotal = COSTA340 + COSTA1000 + COSTAXG + ((decimal)SCTotal * (decimal)0.5) + ((decimal)TRADETotal * (decimal)0.5);
            COSTATotal340 = COSTATotal / 340;

            ETHOTotal = ETHO340 + ETHO1000 + ETHOXG;
            ETHOTotal340 = ETHOTotal / 340;            
            //Calculate +

            //Go back to strings -
            BrazilTotalG.Text = Convert.ToString(BRATotal);
            BrazilTotalG340.Text = Convert.ToString(BRATotal340);

            BaliTotalG.Text = Convert.ToString(BALITotal);
            BaliTotalG340.Text = Convert.ToString(BALITotal340);

            CostaTotalG.Text = Convert.ToString(COSTATotal);
            CostaTotalG340.Text = Convert.ToString(COSTATotal340);

            EthopianTotalG.Text = Convert.ToString(ETHOTotal);
            EthopianTotalG340.Text = Convert.ToString(ETHOTotal340);

            SouthCendralTotalG.Text = Convert.ToString(SCTotal);
            SouthCendralTotalG340.Text = Convert.ToString(SCTotal340);

            TradewindsTotalG.Text = Convert.ToString(TRADETotal);
            TradewindsTotalG340.Text = Convert.ToString(TRADETotal340);
            //GO back to strings +
        }
    }
}
