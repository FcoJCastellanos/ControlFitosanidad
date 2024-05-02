; ModuleID = 'obj\Debug\130\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [288 x i32] [
	i32 17586262, ; 0: FitosanidadAgroberries.dll => 0x10c5856 => 6
	i32 32687329, ; 1: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 76
	i32 34715100, ; 2: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 109
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 100
	i32 90921095, ; 4: Syncfusion.SfNumericTextBox.XForms.Android => 0x56b5887 => 26
	i32 101534019, ; 5: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 90
	i32 120558881, ; 6: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 90
	i32 165246403, ; 7: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 56
	i32 166922606, ; 8: Xamarin.Android.Support.Compat.dll => 0x9f3096e => 40
	i32 172012715, ; 9: FastAndroidCamera.dll => 0xa40b4ab => 5
	i32 182336117, ; 10: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 91
	i32 209399409, ; 11: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 54
	i32 212497893, ; 12: Xamarin.Forms.Maps.Android => 0xcaa75e5 => 103
	i32 219130465, ; 13: Xamarin.Android.Support.v4 => 0xd0faa61 => 45
	i32 220171995, ; 14: System.Diagnostics.Debug => 0xd1f8edb => 126
	i32 230216969, ; 15: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 71
	i32 230752869, ; 16: Microsoft.CSharp.dll => 0xdc10265 => 139
	i32 231814094, ; 17: System.Globalization => 0xdd133ce => 129
	i32 232815796, ; 18: System.Web.Services => 0xde07cb4 => 138
	i32 261689757, ; 19: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 59
	i32 278686392, ; 20: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 75
	i32 280482487, ; 21: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 69
	i32 318968648, ; 22: Xamarin.AndroidX.Activity.dll => 0x13031348 => 46
	i32 319314094, ; 23: Xamarin.Forms.Maps => 0x130858ae => 104
	i32 321597661, ; 24: System.Numerics => 0x132b30dd => 33
	i32 334355562, ; 25: ZXing.Net.Mobile.Forms.dll => 0x13eddc6a => 119
	i32 342366114, ; 26: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 73
	i32 347068432, ; 27: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 14
	i32 385762202, ; 28: System.Memory.dll => 0x16fe439a => 31
	i32 389971796, ; 29: Xamarin.Android.Support.Core.UI => 0x173e7f54 => 41
	i32 441335492, ; 30: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 58
	i32 442521989, ; 31: Xamarin.Essentials => 0x1a605985 => 99
	i32 442565967, ; 32: System.Collections => 0x1a61054f => 124
	i32 450948140, ; 33: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 68
	i32 465846621, ; 34: mscorlib => 0x1bc4415d => 10
	i32 469710990, ; 35: System.dll => 0x1bff388e => 30
	i32 476646585, ; 36: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 69
	i32 486930444, ; 37: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 80
	i32 498788369, ; 38: System.ObjectModel => 0x1dbae811 => 123
	i32 514659665, ; 39: Xamarin.Android.Support.Compat => 0x1ead1551 => 40
	i32 526420162, ; 40: System.Transactions.dll => 0x1f6088c2 => 133
	i32 545304856, ; 41: System.Runtime.Extensions => 0x2080b118 => 130
	i32 588548651, ; 42: FitosanidadAgroberries.Android.dll => 0x23148a2b => 0
	i32 605376203, ; 43: System.IO.Compression.FileSystem => 0x24154ecb => 136
	i32 627609679, ; 44: Xamarin.AndroidX.CustomView => 0x2568904f => 64
	i32 663517072, ; 45: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 96
	i32 666292255, ; 46: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 51
	i32 690569205, ; 47: System.Xml.Linq.dll => 0x29293ff5 => 38
	i32 692692150, ; 48: Xamarin.Android.Support.Annotations => 0x2949a4b6 => 39
	i32 700284507, ; 49: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 114
	i32 708149616, ; 50: Syncfusion.Data.Portable.dll => 0x2a358170 => 18
	i32 719061231, ; 51: Syncfusion.Core.XForms.dll => 0x2adc00ef => 17
	i32 729844822, ; 52: Syncfusion.SfComboBox.XForms.Android => 0x2b808c56 => 21
	i32 748832960, ; 53: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 12
	i32 775507847, ; 54: System.IO.Compression => 0x2e394f87 => 135
	i32 809851609, ; 55: System.Drawing.Common.dll => 0x30455ad9 => 2
	i32 843511501, ; 56: Xamarin.AndroidX.Print => 0x3246f6cd => 87
	i32 877678880, ; 57: System.Globalization.dll => 0x34505120 => 129
	i32 882883187, ; 58: Xamarin.Android.Support.v4.dll => 0x349fba73 => 45
	i32 928116545, ; 59: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 109
	i32 954320159, ; 60: ZXing.Net.Mobile.Forms => 0x38e1c51f => 119
	i32 958213972, ; 61: Xamarin.Android.Support.Media.Compat => 0x391d2f54 => 44
	i32 967690846, ; 62: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 73
	i32 974778368, ; 63: FormsViewGroup.dll => 0x3a19f000 => 7
	i32 992768348, ; 64: System.Collections.dll => 0x3b2c715c => 124
	i32 1012816738, ; 65: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 89
	i32 1035644815, ; 66: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 50
	i32 1042160112, ; 67: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 106
	i32 1052210849, ; 68: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 77
	i32 1084122840, ; 69: Xamarin.Kotlin.StdLib => 0x409e66d8 => 116
	i32 1098259244, ; 70: System => 0x41761b2c => 30
	i32 1134191450, ; 71: ZXingNetMobile.dll => 0x439a635a => 121
	i32 1175144683, ; 72: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 94
	i32 1178241025, ; 73: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 84
	i32 1204270330, ; 74: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 51
	i32 1267360935, ; 75: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 95
	i32 1292207520, ; 76: SQLitePCLRaw.core.dll => 0x4d0585a0 => 13
	i32 1293217323, ; 77: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 66
	i32 1354490624, ; 78: Xamarin.Forms.GoogleMaps.dll => 0x50bbe300 => 102
	i32 1364015309, ; 79: System.IO => 0x514d38cd => 142
	i32 1365406463, ; 80: System.ServiceModel.Internals.dll => 0x516272ff => 122
	i32 1371845985, ; 81: Xamarin.Forms.GoogleMaps.Android => 0x51c4b561 => 101
	i32 1376866003, ; 82: Xamarin.AndroidX.SavedState => 0x52114ed3 => 89
	i32 1395857551, ; 83: Xamarin.AndroidX.Media.dll => 0x5333188f => 81
	i32 1406073936, ; 84: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 60
	i32 1411638395, ; 85: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 35
	i32 1445445088, ; 86: Xamarin.Android.Support.Fragment => 0x5627bde0 => 43
	i32 1457743152, ; 87: System.Runtime.Extensions.dll => 0x56e36530 => 130
	i32 1460219004, ; 88: Xamarin.Forms.Xaml => 0x57092c7c => 107
	i32 1462112819, ; 89: System.IO.Compression.dll => 0x57261233 => 135
	i32 1469204771, ; 90: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 49
	i32 1516315406, ; 91: Syncfusion.Core.XForms.Android.dll => 0x5a61230e => 16
	i32 1530663695, ; 92: Xamarin.Forms.Maps.dll => 0x5b3c130f => 104
	i32 1543031311, ; 93: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 143
	i32 1550322496, ; 94: System.Reflection.Extensions.dll => 0x5c680b40 => 1
	i32 1571005899, ; 95: zxing.portable => 0x5da3a5cb => 120
	i32 1574652163, ; 96: Xamarin.Android.Support.Core.Utils.dll => 0x5ddb4903 => 42
	i32 1582372066, ; 97: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 65
	i32 1592978981, ; 98: System.Runtime.Serialization.dll => 0x5ef2ee25 => 3
	i32 1622152042, ; 99: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 79
	i32 1624863272, ; 100: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 98
	i32 1636350590, ; 101: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 63
	i32 1639515021, ; 102: System.Net.Http.dll => 0x61b9038d => 32
	i32 1639986890, ; 103: System.Text.RegularExpressions => 0x61c036ca => 143
	i32 1657153582, ; 104: System.Runtime => 0x62c6282e => 36
	i32 1658241508, ; 105: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 92
	i32 1658251792, ; 106: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 108
	i32 1670060433, ; 107: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 59
	i32 1698840827, ; 108: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 115
	i32 1701541528, ; 109: System.Diagnostics.Debug.dll => 0x656b7698 => 126
	i32 1711441057, ; 110: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 14
	i32 1712766919, ; 111: Syncfusion.SfComboBox.XForms.dll => 0x6616bfc7 => 22
	i32 1726116996, ; 112: System.Reflection.dll => 0x66e27484 => 127
	i32 1729485958, ; 113: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 55
	i32 1765942094, ; 114: System.Reflection.Extensions => 0x6942234e => 1
	i32 1766324549, ; 115: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 91
	i32 1776026572, ; 116: System.Core.dll => 0x69dc03cc => 29
	i32 1788241197, ; 117: Xamarin.AndroidX.Fragment => 0x6a96652d => 68
	i32 1808609942, ; 118: Xamarin.AndroidX.Loader => 0x6bcd3296 => 79
	i32 1813058853, ; 119: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 116
	i32 1813201214, ; 120: Xamarin.Google.Android.Material => 0x6c13413e => 108
	i32 1818569960, ; 121: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 85
	i32 1857390963, ; 122: FitosanidadAgroberries => 0x6eb58973 => 6
	i32 1867746548, ; 123: Xamarin.Essentials.dll => 0x6f538cf4 => 99
	i32 1878053835, ; 124: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 107
	i32 1881862856, ; 125: Xamarin.Forms.Maps.Android.dll => 0x702af2c8 => 103
	i32 1885316902, ; 126: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 52
	i32 1904184254, ; 127: FastAndroidCamera => 0x717f8bbe => 5
	i32 1908813208, ; 128: Xamarin.GooglePlayServices.Basement => 0x71c62d98 => 111
	i32 1919157823, ; 129: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 82
	i32 1983156543, ; 130: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 115
	i32 2011961780, ; 131: System.Buffers.dll => 0x77ec19b4 => 28
	i32 2019465201, ; 132: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 77
	i32 2055257422, ; 133: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 74
	i32 2079903147, ; 134: System.Runtime.dll => 0x7bf8cdab => 36
	i32 2090596640, ; 135: System.Numerics.Vectors => 0x7c9bf920 => 34
	i32 2097448633, ; 136: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 70
	i32 2103459038, ; 137: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 15
	i32 2126786730, ; 138: Xamarin.Forms.Platform.Android => 0x7ec430aa => 105
	i32 2129483829, ; 139: Xamarin.GooglePlayServices.Base.dll => 0x7eed5835 => 110
	i32 2166116741, ; 140: Xamarin.Android.Support.Core.Utils => 0x811c5185 => 42
	i32 2193016926, ; 141: System.ObjectModel.dll => 0x82b6c85e => 123
	i32 2195767025, ; 142: Syncfusion.SfDataGrid.XForms.Android.dll => 0x82e0bef1 => 23
	i32 2201231467, ; 143: System.Net.Http => 0x8334206b => 32
	i32 2217644978, ; 144: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 94
	i32 2244775296, ; 145: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 80
	i32 2256548716, ; 146: Xamarin.AndroidX.MultiDex => 0x8680336c => 82
	i32 2261435625, ; 147: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 72
	i32 2279755925, ; 148: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 88
	i32 2315684594, ; 149: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 47
	i32 2324593299, ; 150: Syncfusion.SfDataGrid.XForms => 0x8a8e7a93 => 24
	i32 2329204181, ; 151: zxing.portable.dll => 0x8ad4d5d5 => 120
	i32 2330457430, ; 152: Xamarin.Android.Support.Core.UI.dll => 0x8ae7f556 => 41
	i32 2341995103, ; 153: ZXingNetMobile => 0x8b98025f => 121
	i32 2343171156, ; 154: Syncfusion.Core.XForms => 0x8ba9f454 => 17
	i32 2354730003, ; 155: Syncfusion.Licensing => 0x8c5a5413 => 20
	i32 2373288475, ; 156: Xamarin.Android.Support.Fragment.dll => 0x8d75821b => 43
	i32 2409053734, ; 157: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 86
	i32 2431243866, ; 158: ZXing.Net.Mobile.Core.dll => 0x90e9d65a => 117
	i32 2445024337, ; 159: Xamarin.Forms.GoogleMaps.Android.dll => 0x91bc1c51 => 101
	i32 2454642406, ; 160: System.Text.Encoding.dll => 0x924edee6 => 141
	i32 2465273461, ; 161: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 12
	i32 2465532216, ; 162: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 58
	i32 2471841756, ; 163: netstandard.dll => 0x93554fdc => 131
	i32 2475788418, ; 164: Java.Interop.dll => 0x93918882 => 8
	i32 2482213323, ; 165: ZXing.Net.Mobile.Forms.Android => 0x93f391cb => 118
	i32 2501346920, ; 166: System.Data.DataSetExtensions => 0x95178668 => 134
	i32 2505896520, ; 167: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 76
	i32 2562349572, ; 168: Microsoft.CSharp => 0x98ba5a04 => 139
	i32 2581819634, ; 169: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 95
	i32 2620871830, ; 170: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 63
	i32 2624644809, ; 171: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 67
	i32 2633051222, ; 172: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 75
	i32 2693849962, ; 173: System.IO.dll => 0xa090e36a => 142
	i32 2701096212, ; 174: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 92
	i32 2715334215, ; 175: System.Threading.Tasks.dll => 0xa1d8b647 => 125
	i32 2732626843, ; 176: Xamarin.AndroidX.Activity => 0xa2e0939b => 46
	i32 2737747696, ; 177: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 49
	i32 2766581644, ; 178: Xamarin.Forms.Core => 0xa4e6af8c => 100
	i32 2770495804, ; 179: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 114
	i32 2778768386, ; 180: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 97
	i32 2810250172, ; 181: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 60
	i32 2819470561, ; 182: System.Xml.dll => 0xa80db4e1 => 37
	i32 2847418871, ; 183: Xamarin.GooglePlayServices.Base => 0xa9b829f7 => 110
	i32 2853208004, ; 184: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 97
	i32 2855708567, ; 185: Xamarin.AndroidX.Transition => 0xaa36a797 => 93
	i32 2868557005, ; 186: Syncfusion.Licensing.dll => 0xaafab4cd => 20
	i32 2874148507, ; 187: Syncfusion.Core.XForms.Android => 0xab50069b => 16
	i32 2901442782, ; 188: System.Reflection => 0xacf080de => 127
	i32 2903344695, ; 189: System.ComponentModel.Composition => 0xad0d8637 => 137
	i32 2905242038, ; 190: mscorlib.dll => 0xad2a79b6 => 10
	i32 2916838712, ; 191: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 98
	i32 2917608622, ; 192: Behaviors.dll => 0xade72cae => 4
	i32 2919462931, ; 193: System.Numerics.Vectors.dll => 0xae037813 => 34
	i32 2921128767, ; 194: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 48
	i32 2969700472, ; 195: Syncfusion.Data.Portable => 0xb1020878 => 18
	i32 2978675010, ; 196: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 66
	i32 3017076677, ; 197: Xamarin.GooglePlayServices.Maps => 0xb3d4efc5 => 112
	i32 3024354802, ; 198: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 71
	i32 3044182254, ; 199: FormsViewGroup => 0xb57288ee => 7
	i32 3048527850, ; 200: Syncfusion.SfNumericTextBox.Android.dll => 0xb5b4d7ea => 25
	i32 3057625584, ; 201: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 83
	i32 3058099980, ; 202: Xamarin.GooglePlayServices.Tasks => 0xb646e70c => 113
	i32 3075834255, ; 203: System.Threading.Tasks => 0xb755818f => 125
	i32 3092211740, ; 204: Xamarin.Android.Support.Media.Compat.dll => 0xb84f681c => 44
	i32 3111772706, ; 205: System.Runtime.Serialization => 0xb979e222 => 3
	i32 3204380047, ; 206: System.Data.dll => 0xbefef58f => 132
	i32 3211777861, ; 207: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 65
	i32 3220365878, ; 208: System.Threading => 0xbff2e236 => 128
	i32 3230466174, ; 209: Xamarin.GooglePlayServices.Basement.dll => 0xc08d007e => 111
	i32 3238542748, ; 210: Syncfusion.SfDataGrid.XForms.Android => 0xc1083d9c => 23
	i32 3247949154, ; 211: Mono.Security => 0xc197c562 => 140
	i32 3258312781, ; 212: Xamarin.AndroidX.CardView => 0xc235e84d => 55
	i32 3267021929, ; 213: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 53
	i32 3286872994, ; 214: SQLite-net.dll => 0xc3e9b3a2 => 11
	i32 3299363146, ; 215: System.Text.Encoding => 0xc4a8494a => 141
	i32 3317135071, ; 216: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 64
	i32 3317144872, ; 217: System.Data => 0xc5b79d28 => 132
	i32 3329003366, ; 218: Syncfusion.SfNumericTextBox.XForms.Android.dll => 0xc66c8f66 => 26
	i32 3340431453, ; 219: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 52
	i32 3346324047, ; 220: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 84
	i32 3353484488, ; 221: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 70
	i32 3360279109, ; 222: SQLitePCLRaw.core => 0xc849ca45 => 13
	i32 3362522851, ; 223: Xamarin.AndroidX.Core => 0xc86c06e3 => 62
	i32 3366347497, ; 224: Java.Interop => 0xc8a662e9 => 8
	i32 3374999561, ; 225: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 88
	i32 3395150330, ; 226: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 35
	i32 3404865022, ; 227: System.ServiceModel.Internals => 0xcaf21dfe => 122
	i32 3429136800, ; 228: System.Xml => 0xcc6479a0 => 37
	i32 3430777524, ; 229: netstandard => 0xcc7d82b4 => 131
	i32 3439690031, ; 230: Xamarin.Android.Support.Annotations.dll => 0xcd05812f => 39
	i32 3441283291, ; 231: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 67
	i32 3448958507, ; 232: Syncfusion.GridCommon.Portable.dll => 0xcd92ee2b => 19
	i32 3459516321, ; 233: Xamarin.Forms.GoogleMaps => 0xce3407a1 => 102
	i32 3476120550, ; 234: Mono.Android => 0xcf3163e6 => 9
	i32 3486566296, ; 235: System.Transactions => 0xcfd0c798 => 133
	i32 3493954962, ; 236: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 57
	i32 3501239056, ; 237: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 53
	i32 3509114376, ; 238: System.Xml.Linq => 0xd128d608 => 38
	i32 3536029504, ; 239: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 105
	i32 3567349600, ; 240: System.ComponentModel.Composition.dll => 0xd4a16f60 => 137
	i32 3612305132, ; 241: Syncfusion.SfDataGrid.XForms.dll => 0xd74f66ec => 24
	i32 3618140916, ; 242: Xamarin.AndroidX.Preference => 0xd7a872f4 => 86
	i32 3627220390, ; 243: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 87
	i32 3632266177, ; 244: Syncfusion.SfComboBox.XForms => 0xd87ffbc1 => 22
	i32 3632359727, ; 245: Xamarin.Forms.Platform => 0xd881692f => 106
	i32 3633644679, ; 246: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 48
	i32 3641597786, ; 247: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 74
	i32 3672681054, ; 248: Mono.Android.dll => 0xdae8aa5e => 9
	i32 3676310014, ; 249: System.Web.Services.dll => 0xdb2009fe => 138
	i32 3682565725, ; 250: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 54
	i32 3684561358, ; 251: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 57
	i32 3688380121, ; 252: Behaviors => 0xdbd836d9 => 4
	i32 3689375977, ; 253: System.Drawing.Common => 0xdbe768e9 => 2
	i32 3693477420, ; 254: Syncfusion.SfNumericTextBox.XForms => 0xdc25fe2c => 27
	i32 3706696989, ; 255: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 61
	i32 3718780102, ; 256: Xamarin.AndroidX.Annotation => 0xdda814c6 => 47
	i32 3724971120, ; 257: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 83
	i32 3754567612, ; 258: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 15
	i32 3758932259, ; 259: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 72
	i32 3786282454, ; 260: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 56
	i32 3822602673, ; 261: Xamarin.AndroidX.Media => 0xe3d849b1 => 81
	i32 3829621856, ; 262: System.Numerics.dll => 0xe4436460 => 33
	i32 3847036339, ; 263: ZXing.Net.Mobile.Forms.Android.dll => 0xe54d1db3 => 118
	i32 3876362041, ; 264: SQLite-net => 0xe70c9739 => 11
	i32 3885922214, ; 265: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 93
	i32 3896760992, ; 266: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 62
	i32 3920810846, ; 267: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 136
	i32 3921031405, ; 268: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 96
	i32 3931092270, ; 269: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 85
	i32 3945713374, ; 270: System.Data.DataSetExtensions.dll => 0xeb2ecede => 134
	i32 3955647286, ; 271: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 50
	i32 3965022950, ; 272: Syncfusion.SfComboBox.XForms.Android.dll => 0xec5572e6 => 21
	i32 3970018735, ; 273: Xamarin.GooglePlayServices.Tasks.dll => 0xeca1adaf => 113
	i32 4025784931, ; 274: System.Memory => 0xeff49a63 => 31
	i32 4051712506, ; 275: Syncfusion.GridCommon.Portable => 0xf18039fa => 19
	i32 4064971021, ; 276: FitosanidadAgroberries.Android => 0xf24a890d => 0
	i32 4073602200, ; 277: System.Threading.dll => 0xf2ce3c98 => 128
	i32 4090812903, ; 278: Syncfusion.SfNumericTextBox.Android => 0xf3d4d9e7 => 25
	i32 4105002889, ; 279: Mono.Security.dll => 0xf4ad5f89 => 140
	i32 4118017053, ; 280: Syncfusion.SfNumericTextBox.XForms.dll => 0xf573f41d => 27
	i32 4151237749, ; 281: System.Core => 0xf76edc75 => 29
	i32 4182413190, ; 282: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 78
	i32 4186595366, ; 283: ZXing.Net.Mobile.Core => 0xf98a6026 => 117
	i32 4256097574, ; 284: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 61
	i32 4260525087, ; 285: System.Buffers => 0xfdf2741f => 28
	i32 4278134329, ; 286: Xamarin.GooglePlayServices.Maps.dll => 0xfeff2639 => 112
	i32 4292120959 ; 287: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 78
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [288 x i32] [
	i32 6, i32 76, i32 109, i32 100, i32 26, i32 90, i32 90, i32 56, ; 0..7
	i32 40, i32 5, i32 91, i32 54, i32 103, i32 45, i32 126, i32 71, ; 8..15
	i32 139, i32 129, i32 138, i32 59, i32 75, i32 69, i32 46, i32 104, ; 16..23
	i32 33, i32 119, i32 73, i32 14, i32 31, i32 41, i32 58, i32 99, ; 24..31
	i32 124, i32 68, i32 10, i32 30, i32 69, i32 80, i32 123, i32 40, ; 32..39
	i32 133, i32 130, i32 0, i32 136, i32 64, i32 96, i32 51, i32 38, ; 40..47
	i32 39, i32 114, i32 18, i32 17, i32 21, i32 12, i32 135, i32 2, ; 48..55
	i32 87, i32 129, i32 45, i32 109, i32 119, i32 44, i32 73, i32 7, ; 56..63
	i32 124, i32 89, i32 50, i32 106, i32 77, i32 116, i32 30, i32 121, ; 64..71
	i32 94, i32 84, i32 51, i32 95, i32 13, i32 66, i32 102, i32 142, ; 72..79
	i32 122, i32 101, i32 89, i32 81, i32 60, i32 35, i32 43, i32 130, ; 80..87
	i32 107, i32 135, i32 49, i32 16, i32 104, i32 143, i32 1, i32 120, ; 88..95
	i32 42, i32 65, i32 3, i32 79, i32 98, i32 63, i32 32, i32 143, ; 96..103
	i32 36, i32 92, i32 108, i32 59, i32 115, i32 126, i32 14, i32 22, ; 104..111
	i32 127, i32 55, i32 1, i32 91, i32 29, i32 68, i32 79, i32 116, ; 112..119
	i32 108, i32 85, i32 6, i32 99, i32 107, i32 103, i32 52, i32 5, ; 120..127
	i32 111, i32 82, i32 115, i32 28, i32 77, i32 74, i32 36, i32 34, ; 128..135
	i32 70, i32 15, i32 105, i32 110, i32 42, i32 123, i32 23, i32 32, ; 136..143
	i32 94, i32 80, i32 82, i32 72, i32 88, i32 47, i32 24, i32 120, ; 144..151
	i32 41, i32 121, i32 17, i32 20, i32 43, i32 86, i32 117, i32 101, ; 152..159
	i32 141, i32 12, i32 58, i32 131, i32 8, i32 118, i32 134, i32 76, ; 160..167
	i32 139, i32 95, i32 63, i32 67, i32 75, i32 142, i32 92, i32 125, ; 168..175
	i32 46, i32 49, i32 100, i32 114, i32 97, i32 60, i32 37, i32 110, ; 176..183
	i32 97, i32 93, i32 20, i32 16, i32 127, i32 137, i32 10, i32 98, ; 184..191
	i32 4, i32 34, i32 48, i32 18, i32 66, i32 112, i32 71, i32 7, ; 192..199
	i32 25, i32 83, i32 113, i32 125, i32 44, i32 3, i32 132, i32 65, ; 200..207
	i32 128, i32 111, i32 23, i32 140, i32 55, i32 53, i32 11, i32 141, ; 208..215
	i32 64, i32 132, i32 26, i32 52, i32 84, i32 70, i32 13, i32 62, ; 216..223
	i32 8, i32 88, i32 35, i32 122, i32 37, i32 131, i32 39, i32 67, ; 224..231
	i32 19, i32 102, i32 9, i32 133, i32 57, i32 53, i32 38, i32 105, ; 232..239
	i32 137, i32 24, i32 86, i32 87, i32 22, i32 106, i32 48, i32 74, ; 240..247
	i32 9, i32 138, i32 54, i32 57, i32 4, i32 2, i32 27, i32 61, ; 248..255
	i32 47, i32 83, i32 15, i32 72, i32 56, i32 81, i32 33, i32 118, ; 256..263
	i32 11, i32 93, i32 62, i32 136, i32 96, i32 85, i32 134, i32 50, ; 264..271
	i32 21, i32 113, i32 31, i32 19, i32 0, i32 128, i32 25, i32 140, ; 272..279
	i32 27, i32 29, i32 78, i32 117, i32 61, i32 28, i32 112, i32 78 ; 288..287
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}
