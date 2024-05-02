; ModuleID = 'obj\Debug\130\android\marshal_methods.x86_64.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86_64.ll"
target datalayout = "e-m:e-p270:32:32-p271:32:32-p272:64:64-i64:64-f80:128-n8:16:32:64-S128"
target triple = "x86_64-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [288 x i64] [
	i64 24362543149721218, ; 0: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 67
	i64 120698629574877762, ; 1: Mono.Android => 0x1accec39cafe242 => 9
	i64 210515253464952879, ; 2: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 56
	i64 232391251801502327, ; 3: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 89
	i64 276473666272823710, ; 4: Xamarin.Forms.GoogleMaps => 0x3d63b55abf1099e => 102
	i64 295915112840604065, ; 5: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 90
	i64 316157742385208084, ; 6: Xamarin.AndroidX.Core.Core.Ktx.dll => 0x46337caa7dc1b14 => 61
	i64 634308326490598313, ; 7: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 76
	i64 687654259221141486, ; 8: Xamarin.GooglePlayServices.Base => 0x98b09e7c92917ee => 110
	i64 702024105029695270, ; 9: System.Drawing.Common => 0x9be17343c0e7726 => 2
	i64 720058930071658100, ; 10: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 70
	i64 870603111519317375, ; 11: SQLitePCLRaw.lib.e_sqlite3.android => 0xc1500ead2756d7f => 14
	i64 872800313462103108, ; 12: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 66
	i64 940822596282819491, ; 13: System.Transactions => 0xd0e792aa81923a3 => 133
	i64 996343623809489702, ; 14: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 106
	i64 1000557547492888992, ; 15: Mono.Security.dll => 0xde2b1c9cba651a0 => 140
	i64 1120440138749646132, ; 16: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 108
	i64 1301485588176585670, ; 17: SQLitePCLRaw.core => 0x120fce3f338e43c6 => 13
	i64 1315114680217950157, ; 18: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 51
	i64 1342439039765371018, ; 19: Xamarin.Android.Support.Fragment => 0x12a14d31b1d4d88a => 43
	i64 1425944114962822056, ; 20: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 3
	i64 1435064484980070193, ; 21: Syncfusion.SfComboBox.XForms.dll => 0x13ea5f8bb9041731 => 22
	i64 1518315023656898250, ; 22: SQLitePCLRaw.provider.e_sqlite3 => 0x151223783a354eca => 15
	i64 1624659445732251991, ; 23: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 49
	i64 1628611045998245443, ; 24: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 78
	i64 1636321030536304333, ; 25: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 71
	i64 1743969030606105336, ; 26: System.Memory.dll => 0x1833d297e88f2af8 => 31
	i64 1795316252682057001, ; 27: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 50
	i64 1836611346387731153, ; 28: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 89
	i64 1875917498431009007, ; 29: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 47
	i64 1938067011858688285, ; 30: Xamarin.Android.Support.v4.dll => 0x1ae565add0bd691d => 45
	i64 1981742497975770890, ; 31: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 77
	i64 2076847052340733488, ; 32: Syncfusion.Core.XForms => 0x1cd27163f7962630 => 17
	i64 2126915263223078201, ; 33: Syncfusion.GridCommon.Portable => 0x1d845229bbc49d39 => 19
	i64 2136356949452311481, ; 34: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 82
	i64 2165725771938924357, ; 35: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 54
	i64 2262844636196693701, ; 36: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 66
	i64 2284400282711631002, ; 37: System.Web.Services => 0x1fb3d1f42fd4249a => 138
	i64 2329709569556905518, ; 38: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 74
	i64 2337758774805907496, ; 39: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 35
	i64 2469392061734276978, ; 40: Syncfusion.Core.XForms.Android.dll => 0x22450aff2ad74f72 => 16
	i64 2470498323731680442, ; 41: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 60
	i64 2479423007379663237, ; 42: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 94
	i64 2497223385847772520, ; 43: System.Runtime => 0x22a7eb7046413568 => 36
	i64 2547086958574651984, ; 44: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 46
	i64 2592350477072141967, ; 45: System.Xml.dll => 0x23f9e10627330e8f => 37
	i64 2624866290265602282, ; 46: mscorlib.dll => 0x246d65fbde2db8ea => 10
	i64 2694427813909235223, ; 47: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 86
	i64 2783046991838674048, ; 48: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 35
	i64 2960931600190307745, ; 49: Xamarin.Forms.Core => 0x2917579a49927da1 => 100
	i64 3017704767998173186, ; 50: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 108
	i64 3022227708164871115, ; 51: Xamarin.Android.Support.Media.Compat.dll => 0x29f11c168f8293cb => 44
	i64 3289520064315143713, ; 52: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 73
	i64 3303437397778967116, ; 53: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 48
	i64 3311221304742556517, ; 54: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 34
	i64 3411255996856937470, ; 55: Xamarin.GooglePlayServices.Basement => 0x2f5737416a942bfe => 111
	i64 3493805808809882663, ; 56: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 92
	i64 3522470458906976663, ; 57: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 91
	i64 3531994851595924923, ; 58: System.Numerics => 0x31042a9aade235bb => 33
	i64 3571415421602489686, ; 59: System.Runtime.dll => 0x319037675df7e556 => 36
	i64 3716579019761409177, ; 60: netstandard.dll => 0x3393f0ed5c8c5c99 => 131
	i64 3727469159507183293, ; 61: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 88
	i64 3730887114094830029, ; 62: Syncfusion.GridCommon.Portable.dll => 0x33c6c6102cb461cd => 19
	i64 3772598417116884899, ; 63: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 67
	i64 3908336291285777176, ; 64: Syncfusion.SfNumericTextBox.XForms.Android.dll => 0x363d332650db3b18 => 26
	i64 3936216335706411319, ; 65: Xamarin.Forms.GoogleMaps.dll => 0x36a03fe700ded137 => 102
	i64 3966267475168208030, ; 66: System.Memory => 0x370b03412596249e => 31
	i64 4201423742386704971, ; 67: Xamarin.AndroidX.Core.Core.Ktx => 0x3a4e74a233da124b => 61
	i64 4247996603072512073, ; 68: Xamarin.GooglePlayServices.Tasks => 0x3af3ea6755340049 => 113
	i64 4255796613242758200, ; 69: zxing.portable => 0x3b0fa078b8a52438 => 120
	i64 4292233171264798357, ; 70: ZXing.Net.Mobile.Core.dll => 0x3b911353fa62fe95 => 117
	i64 4337444564132831293, ; 71: SQLitePCLRaw.batteries_v2.dll => 0x3c31b2d9ae16203d => 12
	i64 4339484998458906887, ; 72: FitosanidadAgroberries.dll => 0x3c38f29d51479907 => 6
	i64 4525561845656915374, ; 73: System.ServiceModel.Internals => 0x3ece06856b710dae => 122
	i64 4636684751163556186, ; 74: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 96
	i64 4782108999019072045, ; 75: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 53
	i64 4794310189461587505, ; 76: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 46
	i64 4795410492532947900, ; 77: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 91
	i64 5142919913060024034, ; 78: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 105
	i64 5203618020066742981, ; 79: Xamarin.Essentials => 0x4836f704f0e652c5 => 99
	i64 5205316157927637098, ; 80: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 80
	i64 5233983725610684227, ; 81: FastAndroidCamera => 0x48a2d877b5334f43 => 5
	i64 5256995213548036366, ; 82: Xamarin.Forms.Maps.Android.dll => 0x48f4994b4175a10e => 103
	i64 5348796042099802469, ; 83: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 81
	i64 5376510917114486089, ; 84: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 94
	i64 5408338804355907810, ; 85: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 93
	i64 5446034149219586269, ; 86: System.Diagnostics.Debug => 0x4b94333452e150dd => 126
	i64 5451019430259338467, ; 87: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 59
	i64 5507995362134886206, ; 88: System.Core.dll => 0x4c705499688c873e => 29
	i64 5540976586714296940, ; 89: Syncfusion.SfNumericTextBox.Android.dll => 0x4ce580d927dcb26c => 25
	i64 5692067934154308417, ; 90: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 98
	i64 5757522595884336624, ; 91: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 57
	i64 5767696078500135884, ; 92: Xamarin.Android.Support.Annotations.dll => 0x500af9065b6a03cc => 39
	i64 5767749323661124970, ; 93: ZXing.Net.Mobile.Core => 0x500b29737652256a => 117
	i64 5814345312393086621, ; 94: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 86
	i64 5896680224035167651, ; 95: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 75
	i64 6085203216496545422, ; 96: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 106
	i64 6086316965293125504, ; 97: FormsViewGroup.dll => 0x5476f10882baef80 => 7
	i64 6183170893902868313, ; 98: SQLitePCLRaw.batteries_v2 => 0x55cf092b0c9d6f59 => 12
	i64 6319713645133255417, ; 99: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 76
	i64 6401687960814735282, ; 100: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 74
	i64 6504860066809920875, ; 101: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 54
	i64 6548213210057960872, ; 102: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 64
	i64 6588599331800941662, ; 103: Xamarin.Android.Support.v4 => 0x5b6f682f335f045e => 45
	i64 6591024623626361694, ; 104: System.Web.Services.dll => 0x5b7805f9751a1b5e => 138
	i64 6659513131007730089, ; 105: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 70
	i64 6711679492026985136, ; 106: Syncfusion.SfNumericTextBox.XForms.dll => 0x5d24acf0208aeab0 => 27
	i64 6876862101832370452, ; 107: System.Xml.Linq => 0x5f6f85a57d108914 => 38
	i64 6894844156784520562, ; 108: System.Numerics.Vectors => 0x5faf683aead1ad72 => 34
	i64 7026608356547306326, ; 109: Syncfusion.Core.XForms.dll => 0x618387125bcb2356 => 17
	i64 7036436454368433159, ; 110: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 72
	i64 7103753931438454322, ; 111: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 69
	i64 7141281584637745974, ; 112: Xamarin.GooglePlayServices.Maps.dll => 0x631aedc3dd5f1b36 => 112
	i64 7330419912715392478, ; 113: Xamarin.Forms.GoogleMaps.Android => 0x65bae21287d9d5de => 101
	i64 7338192458477945005, ; 114: System.Reflection => 0x65d67f295d0740ad => 127
	i64 7394893729458727919, ; 115: Behaviors => 0x669ff0aac826abef => 4
	i64 7488575175965059935, ; 116: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 38
	i64 7489048572193775167, ; 117: System.ObjectModel => 0x67ee71ff6b419e3f => 123
	i64 7566872048948821773, ; 118: Syncfusion.SfDataGrid.XForms => 0x6902ee099a6d3f0d => 24
	i64 7635363394907363464, ; 119: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 100
	i64 7637365915383206639, ; 120: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 99
	i64 7654504624184590948, ; 121: System.Net.Http => 0x6a3a4366801b8264 => 32
	i64 7735176074855944702, ; 122: Microsoft.CSharp => 0x6b58dda848e391fe => 139
	i64 7735352534559001595, ; 123: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 116
	i64 7820441508502274321, ; 124: System.Data => 0x6c87ca1e14ff8111 => 132
	i64 7836164640616011524, ; 125: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 49
	i64 7956423435673659877, ; 126: Syncfusion.SfDataGrid.XForms.Android => 0x6e6ae4f5b5ebe9e5 => 23
	i64 8044118961405839122, ; 127: System.ComponentModel.Composition => 0x6fa2739369944712 => 137
	i64 8064050204834738623, ; 128: System.Collections.dll => 0x6fe942efa61731bf => 124
	i64 8083054321397151520, ; 129: Syncfusion.SfDataGrid.XForms.Android.dll => 0x702cc71457103720 => 23
	i64 8083354569033831015, ; 130: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 73
	i64 8101777744205214367, ; 131: Xamarin.Android.Support.Annotations => 0x706f4beeec84729f => 39
	i64 8103644804370223335, ; 132: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 134
	i64 8113615946733131500, ; 133: System.Reflection.Extensions => 0x70995ab73cf916ec => 1
	i64 8167236081217502503, ; 134: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 8
	i64 8185542183669246576, ; 135: System.Collections => 0x7198e33f4794aa70 => 124
	i64 8290740647658429042, ; 136: System.Runtime.Extensions => 0x730ea0b15c929a72 => 130
	i64 8398329775253868912, ; 137: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 58
	i64 8400357532724379117, ; 138: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 85
	i64 8601935802264776013, ; 139: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 93
	i64 8626175481042262068, ; 140: Java.Interop => 0x77b654e585b55834 => 8
	i64 8638972117149407195, ; 141: Microsoft.CSharp.dll => 0x77e3cb5e8b31d7db => 139
	i64 8639588376636138208, ; 142: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 84
	i64 8684531736582871431, ; 143: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 136
	i64 8853378295825400934, ; 144: Xamarin.Kotlin.StdLib.Common.dll => 0x7add84a720d38466 => 115
	i64 9160380745055597495, ; 145: FitosanidadAgroberries.Android.dll => 0x7f2035c0fc5df3b7 => 0
	i64 9312692141327339315, ; 146: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 98
	i64 9324707631942237306, ; 147: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 50
	i64 9418564226550032778, ; 148: Syncfusion.SfNumericTextBox.XForms.Android => 0x82b5764329b7698a => 26
	i64 9584643793929893533, ; 149: System.IO.dll => 0x85037ebfbbd7f69d => 142
	i64 9659729154652888475, ; 150: System.Text.RegularExpressions => 0x860e407c9991dd9b => 143
	i64 9662334977499516867, ; 151: System.Numerics.dll => 0x8617827802b0cfc3 => 33
	i64 9678050649315576968, ; 152: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 60
	i64 9711637524876806384, ; 153: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 81
	i64 9808709177481450983, ; 154: Mono.Android.dll => 0x881f890734e555e7 => 9
	i64 9825649861376906464, ; 155: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 57
	i64 9834056768316610435, ; 156: System.Transactions.dll => 0x8879968718899783 => 133
	i64 9875200773399460291, ; 157: Xamarin.GooglePlayServices.Base.dll => 0x890bc2c8482339c3 => 110
	i64 9998632235833408227, ; 158: Mono.Security => 0x8ac2470b209ebae3 => 140
	i64 10038780035334861115, ; 159: System.Net.Http.dll => 0x8b50e941206af13b => 32
	i64 10229024438826829339, ; 160: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 64
	i64 10321854143672141184, ; 161: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 114
	i64 10360651442923773544, ; 162: System.Text.Encoding => 0x8fc86d98211c1e68 => 141
	i64 10376576884623852283, ; 163: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 92
	i64 10430153318873392755, ; 164: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 62
	i64 10566960649245365243, ; 165: System.Globalization.dll => 0x92a562b96dcd13fb => 129
	i64 10714184849103829812, ; 166: System.Runtime.Extensions.dll => 0x94b06e5aa4b4bb34 => 130
	i64 10775409704848971057, ; 167: Xamarin.Forms.Maps => 0x9589f20936d1d531 => 104
	i64 10847732767863316357, ; 168: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 51
	i64 11023048688141570732, ; 169: System.Core => 0x98f9bc61168392ac => 29
	i64 11034181033432536911, ; 170: Syncfusion.SfNumericTextBox.XForms => 0x992149303519574f => 27
	i64 11037814507248023548, ; 171: System.Xml => 0x992e31d0412bf7fc => 37
	i64 11088134957033986159, ; 172: FitosanidadAgroberries.Android => 0x99e0f7fef79a186f => 0
	i64 11162124722117608902, ; 173: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 97
	i64 11340910727871153756, ; 174: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 63
	i64 11376461258732682436, ; 175: Xamarin.Android.Support.Compat => 0x9de14f3d5fc13cc4 => 40
	i64 11392833485892708388, ; 176: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 87
	i64 11444370155346000636, ; 177: Xamarin.Forms.Maps.Android => 0x9ed292057b7afafc => 103
	i64 11481714388108425262, ; 178: Syncfusion.SfComboBox.XForms => 0x9f573e673bb1b82e => 22
	i64 11529969570048099689, ; 179: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 97
	i64 11578238080964724296, ; 180: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 72
	i64 11580057168383206117, ; 181: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 47
	i64 11597940890313164233, ; 182: netstandard => 0xa0f429ca8d1805c9 => 131
	i64 11672361001936329215, ; 183: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 69
	i64 11683710219442713716, ; 184: ZXingNetMobile => 0xa224e08aa87bf474 => 121
	i64 11739066727115742305, ; 185: SQLite-net.dll => 0xa2e98afdf8575c61 => 11
	i64 11743665907891708234, ; 186: System.Threading.Tasks => 0xa2f9e1ec30c0214a => 125
	i64 11806260347154423189, ; 187: SQLite-net => 0xa3d8433bc5eb5d95 => 11
	i64 12036099219279441448, ; 188: ZXing.Net.Mobile.Forms => 0xa708d0784e81ee28 => 119
	i64 12102847907131387746, ; 189: System.Buffers => 0xa7f5f40c43256f62 => 28
	i64 12123043025855404482, ; 190: System.Reflection.Extensions.dll => 0xa83db366c0e359c2 => 1
	i64 12137774235383566651, ; 191: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 95
	i64 12279246230491828964, ; 192: SQLitePCLRaw.provider.e_sqlite3.dll => 0xaa68a5636e0512e4 => 15
	i64 12414299427252656003, ; 193: Xamarin.Android.Support.Compat.dll => 0xac48738e28bad783 => 40
	i64 12451044538927396471, ; 194: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 68
	i64 12466513435562512481, ; 195: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 79
	i64 12487638416075308985, ; 196: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 65
	i64 12538491095302438457, ; 197: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 55
	i64 12550732019250633519, ; 198: System.IO.Compression => 0xae2d28465e8e1b2f => 135
	i64 12629983860853673214, ; 199: ZXing.Net.Mobile.Forms.Android.dll => 0xaf46b767a9198cfe => 118
	i64 12700543734426720211, ; 200: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 56
	i64 12708238894395270091, ; 201: System.IO => 0xb05cbbf17d3ba3cb => 142
	i64 12952608645614506925, ; 202: Xamarin.Android.Support.Core.Utils => 0xb3c0e8eff48193ad => 42
	i64 12963446364377008305, ; 203: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 2
	i64 13058651076603825364, ; 204: Syncfusion.Data.Portable.dll => 0xb539a5f76abe4cd4 => 18
	i64 13291835053457086558, ; 205: Xamarin.Forms.GoogleMaps.Android.dll => 0xb876158ed665185e => 101
	i64 13358059602087096138, ; 206: Xamarin.Android.Support.Fragment.dll => 0xb9615c6f1ee5af4a => 43
	i64 13370592475155966277, ; 207: System.Runtime.Serialization => 0xb98de304062ea945 => 3
	i64 13401370062847626945, ; 208: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 95
	i64 13404347523447273790, ; 209: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 58
	i64 13454009404024712428, ; 210: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 109
	i64 13465488254036897740, ; 211: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 116
	i64 13491513212026656886, ; 212: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 52
	i64 13572454107664307259, ; 213: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 88
	i64 13622732128915678507, ; 214: Syncfusion.Core.XForms.Android => 0xbd0daab1e651e52b => 16
	i64 13647433987885684830, ; 215: Syncfusion.SfNumericTextBox.Android => 0xbd656ce79f84d85e => 25
	i64 13647894001087880694, ; 216: System.Data.dll => 0xbd670f48cb071df6 => 132
	i64 13828521679616088467, ; 217: Xamarin.Kotlin.StdLib.Common => 0xbfe8c733724e1993 => 115
	i64 13959074834287824816, ; 218: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 68
	i64 13967638549803255703, ; 219: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 105
	i64 13970307180132182141, ; 220: Syncfusion.Licensing => 0xc1e0805ccade287d => 20
	i64 14061024831517255851, ; 221: Syncfusion.SfComboBox.XForms.Android => 0xc322cb95f48868ab => 21
	i64 14124974489674258913, ; 222: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 55
	i64 14125464355221830302, ; 223: System.Threading.dll => 0xc407bafdbc707a9e => 128
	i64 14172845254133543601, ; 224: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 82
	i64 14261073672896646636, ; 225: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 87
	i64 14327695147300244862, ; 226: System.Reflection.dll => 0xc6d632d338eb4d7e => 127
	i64 14400856865250966808, ; 227: Xamarin.Android.Support.Core.UI => 0xc7da1f051a877d18 => 41
	i64 14486659737292545672, ; 228: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 75
	i64 14538127318538747197, ; 229: Syncfusion.Licensing.dll => 0xc9c1cdc518e77d3d => 20
	i64 14644440854989303794, ; 230: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 80
	i64 14792063746108907174, ; 231: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 109
	i64 14852515768018889994, ; 232: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 63
	i64 14954388675289411854, ; 233: ZXing.Net.Mobile.Forms.dll => 0xcf88a944b7bff10e => 119
	i64 14987728460634540364, ; 234: System.IO.Compression.dll => 0xcfff1ba06622494c => 135
	i64 14988210264188246988, ; 235: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 65
	i64 15076659072870671916, ; 236: System.ObjectModel.dll => 0xd13b0d8c1620662c => 123
	i64 15370334346939861994, ; 237: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 62
	i64 15423352120420908645, ; 238: Syncfusion.SfComboBox.XForms.Android.dll => 0xd60ac1097f74be65 => 21
	i64 15457813392950723921, ; 239: Xamarin.Android.Support.Media.Compat => 0xd6852f61c31a8551 => 44
	i64 15526743539506359484, ; 240: System.Text.Encoding.dll => 0xd77a12fc26de2cbc => 141
	i64 15582737692548360875, ; 241: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 78
	i64 15609085926864131306, ; 242: System.dll => 0xd89e9cf3334914ea => 30
	i64 15777549416145007739, ; 243: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 90
	i64 15810740023422282496, ; 244: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 107
	i64 15817206913877585035, ; 245: System.Threading.Tasks.dll => 0xdb8201e29086ac8b => 125
	i64 15851975962649584118, ; 246: zxing.portable.dll => 0xdbfd882691c261f6 => 120
	i64 15930129725311349754, ; 247: Xamarin.GooglePlayServices.Tasks.dll => 0xdd1330956f12f3fa => 113
	i64 16107354805249926211, ; 248: ZXingNetMobile.dll => 0xdf88d1dade1a6443 => 121
	i64 16119456071779071829, ; 249: FastAndroidCamera.dll => 0xdfb3cfe48ae7b755 => 5
	i64 16154507427712707110, ; 250: System => 0xe03056ea4e39aa26 => 30
	i64 16526376532108668976, ; 251: ZXing.Net.Mobile.Forms.Android => 0xe5597be53cb07030 => 118
	i64 16565028646146589191, ; 252: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 137
	i64 16621146507174665210, ; 253: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 59
	i64 16677317093839702854, ; 254: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 85
	i64 16755018182064898362, ; 255: SQLitePCLRaw.core.dll => 0xe885c843c330813a => 13
	i64 16822611501064131242, ; 256: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 134
	i64 16833383113903931215, ; 257: mscorlib => 0xe99c30c1484d7f4f => 10
	i64 16890310621557459193, ; 258: System.Text.RegularExpressions.dll => 0xea66700587f088f9 => 143
	i64 16920688884252316596, ; 259: FitosanidadAgroberries => 0xead25ce3fcc293b4 => 6
	i64 16932527889823454152, ; 260: Xamarin.Android.Support.Core.Utils.dll => 0xeafc6c67465253c8 => 42
	i64 17024911836938395553, ; 261: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 48
	i64 17031351772568316411, ; 262: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 83
	i64 17037200463775726619, ; 263: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 71
	i64 17162136034847712714, ; 264: Behaviors.dll => 0xee2c27cb780765ca => 4
	i64 17428701562824544279, ; 265: Xamarin.Android.Support.Core.UI.dll => 0xf1df2fbaec73d017 => 41
	i64 17544493274320527064, ; 266: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 53
	i64 17627500474728259406, ; 267: System.Globalization => 0xf4a176498a351f4e => 129
	i64 17685921127322830888, ; 268: System.Diagnostics.Debug.dll => 0xf571038fafa74828 => 126
	i64 17704177640604968747, ; 269: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 79
	i64 17710060891934109755, ; 270: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 77
	i64 17816041456001989629, ; 271: Xamarin.Forms.Maps.dll => 0xf73f4b4f90a1bbfd => 104
	i64 17832140366245679051, ; 272: Syncfusion.Data.Portable => 0xf7787d2f32fa4fcb => 18
	i64 17838668724098252521, ; 273: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 28
	i64 17882897186074144999, ; 274: FormsViewGroup => 0xf82cd03e3ac830e7 => 7
	i64 17891337867145587222, ; 275: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 114
	i64 17892495832318972303, ; 276: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 107
	i64 17928294245072900555, ; 277: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 136
	i64 17969331831154222830, ; 278: Xamarin.GooglePlayServices.Maps => 0xf95fe418471126ee => 112
	i64 17986907704309214542, ; 279: Xamarin.GooglePlayServices.Basement.dll => 0xf99e554223166d4e => 111
	i64 18025913125965088385, ; 280: System.Threading => 0xfa28e87b91334681 => 128
	i64 18116111925905154859, ; 281: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 52
	i64 18121036031235206392, ; 282: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 83
	i64 18129453464017766560, ; 283: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 122
	i64 18219918163864392437, ; 284: Syncfusion.SfDataGrid.XForms.dll => 0xfcda270969d312f5 => 24
	i64 18305135509493619199, ; 285: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 84
	i64 18370042311372477656, ; 286: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0xfeef80274e4094d8 => 14
	i64 18380184030268848184 ; 287: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 96
], align 16
@assembly_image_cache_indices = local_unnamed_addr constant [288 x i32] [
	i32 67, i32 9, i32 56, i32 89, i32 102, i32 90, i32 61, i32 76, ; 0..7
	i32 110, i32 2, i32 70, i32 14, i32 66, i32 133, i32 106, i32 140, ; 8..15
	i32 108, i32 13, i32 51, i32 43, i32 3, i32 22, i32 15, i32 49, ; 16..23
	i32 78, i32 71, i32 31, i32 50, i32 89, i32 47, i32 45, i32 77, ; 24..31
	i32 17, i32 19, i32 82, i32 54, i32 66, i32 138, i32 74, i32 35, ; 32..39
	i32 16, i32 60, i32 94, i32 36, i32 46, i32 37, i32 10, i32 86, ; 40..47
	i32 35, i32 100, i32 108, i32 44, i32 73, i32 48, i32 34, i32 111, ; 48..55
	i32 92, i32 91, i32 33, i32 36, i32 131, i32 88, i32 19, i32 67, ; 56..63
	i32 26, i32 102, i32 31, i32 61, i32 113, i32 120, i32 117, i32 12, ; 64..71
	i32 6, i32 122, i32 96, i32 53, i32 46, i32 91, i32 105, i32 99, ; 72..79
	i32 80, i32 5, i32 103, i32 81, i32 94, i32 93, i32 126, i32 59, ; 80..87
	i32 29, i32 25, i32 98, i32 57, i32 39, i32 117, i32 86, i32 75, ; 88..95
	i32 106, i32 7, i32 12, i32 76, i32 74, i32 54, i32 64, i32 45, ; 96..103
	i32 138, i32 70, i32 27, i32 38, i32 34, i32 17, i32 72, i32 69, ; 104..111
	i32 112, i32 101, i32 127, i32 4, i32 38, i32 123, i32 24, i32 100, ; 112..119
	i32 99, i32 32, i32 139, i32 116, i32 132, i32 49, i32 23, i32 137, ; 120..127
	i32 124, i32 23, i32 73, i32 39, i32 134, i32 1, i32 8, i32 124, ; 128..135
	i32 130, i32 58, i32 85, i32 93, i32 8, i32 139, i32 84, i32 136, ; 136..143
	i32 115, i32 0, i32 98, i32 50, i32 26, i32 142, i32 143, i32 33, ; 144..151
	i32 60, i32 81, i32 9, i32 57, i32 133, i32 110, i32 140, i32 32, ; 152..159
	i32 64, i32 114, i32 141, i32 92, i32 62, i32 129, i32 130, i32 104, ; 160..167
	i32 51, i32 29, i32 27, i32 37, i32 0, i32 97, i32 63, i32 40, ; 168..175
	i32 87, i32 103, i32 22, i32 97, i32 72, i32 47, i32 131, i32 69, ; 176..183
	i32 121, i32 11, i32 125, i32 11, i32 119, i32 28, i32 1, i32 95, ; 184..191
	i32 15, i32 40, i32 68, i32 79, i32 65, i32 55, i32 135, i32 118, ; 192..199
	i32 56, i32 142, i32 42, i32 2, i32 18, i32 101, i32 43, i32 3, ; 200..207
	i32 95, i32 58, i32 109, i32 116, i32 52, i32 88, i32 16, i32 25, ; 208..215
	i32 132, i32 115, i32 68, i32 105, i32 20, i32 21, i32 55, i32 128, ; 216..223
	i32 82, i32 87, i32 127, i32 41, i32 75, i32 20, i32 80, i32 109, ; 224..231
	i32 63, i32 119, i32 135, i32 65, i32 123, i32 62, i32 21, i32 44, ; 232..239
	i32 141, i32 78, i32 30, i32 90, i32 107, i32 125, i32 120, i32 113, ; 240..247
	i32 121, i32 5, i32 30, i32 118, i32 137, i32 59, i32 85, i32 13, ; 248..255
	i32 134, i32 10, i32 143, i32 6, i32 42, i32 48, i32 83, i32 71, ; 256..263
	i32 4, i32 41, i32 53, i32 129, i32 126, i32 79, i32 77, i32 104, ; 264..271
	i32 18, i32 28, i32 7, i32 114, i32 107, i32 136, i32 112, i32 111, ; 272..279
	i32 128, i32 52, i32 83, i32 122, i32 24, i32 84, i32 14, i32 96 ; 288..287
], align 16

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 16; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1}
!llvm.ident = !{!2}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}
