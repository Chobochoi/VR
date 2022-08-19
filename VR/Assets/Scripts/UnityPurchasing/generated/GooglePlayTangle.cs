// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("TsX9+aAapAPo4B+5GgE8Oa8Pue2psvB1dXwP2TM4gjoEgzbVIrveuF6+6zj4rQxZIRz3yKh5i5xpAiYSQplVKhgHeoJ0/169/G7q8rC3haI3o4GQatcTqWrNyNAb+i6W7jcPaWhd3aft2kqbWLTcHt4to8ZdPhWf8E2HxWU/AgKtdENIlq627dtADK1NqMsy3ggQ8cFSF12k9m+MrH3pdS2fHD8tEBsUN5tVm+oQHBwcGB0eSteXUZueoXlqUM7y2AsLyfRhriov0Zn9FDZsLoIlx+40mE8QLJJ3cAPnC4noBuUq07xSBDS1SJJ5Gl26nxwSHS2fHBcfnxwcHYIwSrmrmSM+0aQtgrMC7nRZtT5UQ7PAtz6Sxv9lFqtctvBunh8eHB0c");
        private static int[] order = new int[] { 3,11,4,5,7,9,8,10,9,10,12,12,12,13,14 };
        private static int key = 29;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
