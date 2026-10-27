using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D1 RID: 977
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARTrackableNotifyComponent")]
	[UnrealStructLayout(536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 536)]
	public class UARTrackableNotifyComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060036A0 RID: 13984 RVA: 0x00052CF1 File Offset: 0x00050EF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARTrackableNotifyComponent._ClassPtr;
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x00052D00 File Offset: 0x00050F00
		public UARTrackableNotifyComponent() : this(BuiltinUtils.AllocNativeUObject(UARTrackableNotifyComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x00052D28 File Offset: 0x00050F28
		public UARTrackableNotifyComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARTrackableNotifyComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060036A3 RID: 13987 RVA: 0x00052D5C File Offset: 0x00050F5C
		// (set) Token: 0x060036A4 RID: 13988 RVA: 0x00052D95 File Offset: 0x00050F95
		public FTrackableDelegate OnAddTrackedGeometry
		{
			get
			{
				base.FastCheckIsValid();
				FTrackableDelegate result;
				if ((result = this._OnAddTrackedGeometry) == null)
				{
					result = (this._OnAddTrackedGeometry = new FTrackableDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnAddTrackedGeometry, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnAddTrackedGeometry, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x060036A5 RID: 13989 RVA: 0x00052DB8 File Offset: 0x00050FB8
		// (set) Token: 0x060036A6 RID: 13990 RVA: 0x00052DF1 File Offset: 0x00050FF1
		public FTrackableDelegate OnUpdateTrackedGeometry
		{
			get
			{
				base.FastCheckIsValid();
				FTrackableDelegate result;
				if ((result = this._OnUpdateTrackedGeometry) == null)
				{
					result = (this._OnUpdateTrackedGeometry = new FTrackableDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnUpdateTrackedGeometry, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnUpdateTrackedGeometry, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x060036A7 RID: 13991 RVA: 0x00052E14 File Offset: 0x00051014
		// (set) Token: 0x060036A8 RID: 13992 RVA: 0x00052E4D File Offset: 0x0005104D
		public FTrackableDelegate OnRemoveTrackedGeometry
		{
			get
			{
				base.FastCheckIsValid();
				FTrackableDelegate result;
				if ((result = this._OnRemoveTrackedGeometry) == null)
				{
					result = (this._OnRemoveTrackedGeometry = new FTrackableDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnRemoveTrackedGeometry, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnRemoveTrackedGeometry, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x060036A9 RID: 13993 RVA: 0x00052E70 File Offset: 0x00051070
		// (set) Token: 0x060036AA RID: 13994 RVA: 0x00052EA9 File Offset: 0x000510A9
		public FTrackablePlaneDelegate OnAddTrackedPlane
		{
			get
			{
				base.FastCheckIsValid();
				FTrackablePlaneDelegate result;
				if ((result = this._OnAddTrackedPlane) == null)
				{
					result = (this._OnAddTrackedPlane = new FTrackablePlaneDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnAddTrackedPlane, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnAddTrackedPlane, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x060036AB RID: 13995 RVA: 0x00052ECC File Offset: 0x000510CC
		// (set) Token: 0x060036AC RID: 13996 RVA: 0x00052F05 File Offset: 0x00051105
		public FTrackablePlaneDelegate OnUpdateTrackedPlane
		{
			get
			{
				base.FastCheckIsValid();
				FTrackablePlaneDelegate result;
				if ((result = this._OnUpdateTrackedPlane) == null)
				{
					result = (this._OnUpdateTrackedPlane = new FTrackablePlaneDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnUpdateTrackedPlane, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnUpdateTrackedPlane, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x060036AD RID: 13997 RVA: 0x00052F28 File Offset: 0x00051128
		// (set) Token: 0x060036AE RID: 13998 RVA: 0x00052F61 File Offset: 0x00051161
		public FTrackablePlaneDelegate OnRemoveTrackedPlane
		{
			get
			{
				base.FastCheckIsValid();
				FTrackablePlaneDelegate result;
				if ((result = this._OnRemoveTrackedPlane) == null)
				{
					result = (this._OnRemoveTrackedPlane = new FTrackablePlaneDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnRemoveTrackedPlane, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnRemoveTrackedPlane, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x060036AF RID: 13999 RVA: 0x00052F84 File Offset: 0x00051184
		// (set) Token: 0x060036B0 RID: 14000 RVA: 0x00052FBD File Offset: 0x000511BD
		public FTrackablePointDelegate OnAddTrackedPoint
		{
			get
			{
				base.FastCheckIsValid();
				FTrackablePointDelegate result;
				if ((result = this._OnAddTrackedPoint) == null)
				{
					result = (this._OnAddTrackedPoint = new FTrackablePointDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnAddTrackedPoint, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnAddTrackedPoint, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060036B1 RID: 14001 RVA: 0x00052FE0 File Offset: 0x000511E0
		// (set) Token: 0x060036B2 RID: 14002 RVA: 0x00053019 File Offset: 0x00051219
		public FTrackablePointDelegate OnUpdateTrackedPoint
		{
			get
			{
				base.FastCheckIsValid();
				FTrackablePointDelegate result;
				if ((result = this._OnUpdateTrackedPoint) == null)
				{
					result = (this._OnUpdateTrackedPoint = new FTrackablePointDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnUpdateTrackedPoint, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnUpdateTrackedPoint, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x060036B3 RID: 14003 RVA: 0x0005303C File Offset: 0x0005123C
		// (set) Token: 0x060036B4 RID: 14004 RVA: 0x00053075 File Offset: 0x00051275
		public FTrackablePointDelegate OnRemoveTrackedPoint
		{
			get
			{
				base.FastCheckIsValid();
				FTrackablePointDelegate result;
				if ((result = this._OnRemoveTrackedPoint) == null)
				{
					result = (this._OnRemoveTrackedPoint = new FTrackablePointDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnRemoveTrackedPoint, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnRemoveTrackedPoint, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x060036B5 RID: 14005 RVA: 0x00053098 File Offset: 0x00051298
		// (set) Token: 0x060036B6 RID: 14006 RVA: 0x000530D1 File Offset: 0x000512D1
		public FTrackableImageDelegate OnAddTrackedImage
		{
			get
			{
				base.FastCheckIsValid();
				FTrackableImageDelegate result;
				if ((result = this._OnAddTrackedImage) == null)
				{
					result = (this._OnAddTrackedImage = new FTrackableImageDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnAddTrackedImage, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnAddTrackedImage, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x060036B7 RID: 14007 RVA: 0x000530F4 File Offset: 0x000512F4
		// (set) Token: 0x060036B8 RID: 14008 RVA: 0x0005312D File Offset: 0x0005132D
		public FTrackableImageDelegate OnUpdateTrackedImage
		{
			get
			{
				base.FastCheckIsValid();
				FTrackableImageDelegate result;
				if ((result = this._OnUpdateTrackedImage) == null)
				{
					result = (this._OnUpdateTrackedImage = new FTrackableImageDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnUpdateTrackedImage, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnUpdateTrackedImage, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x060036B9 RID: 14009 RVA: 0x00053150 File Offset: 0x00051350
		// (set) Token: 0x060036BA RID: 14010 RVA: 0x00053189 File Offset: 0x00051389
		public FTrackableImageDelegate OnRemoveTrackedImage
		{
			get
			{
				base.FastCheckIsValid();
				FTrackableImageDelegate result;
				if ((result = this._OnRemoveTrackedImage) == null)
				{
					result = (this._OnRemoveTrackedImage = new FTrackableImageDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnRemoveTrackedImage, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnRemoveTrackedImage, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x060036BB RID: 14011 RVA: 0x000531AC File Offset: 0x000513AC
		// (set) Token: 0x060036BC RID: 14012 RVA: 0x000531E5 File Offset: 0x000513E5
		public FTrackableFaceDelegate OnAddTrackedFace
		{
			get
			{
				base.FastCheckIsValid();
				FTrackableFaceDelegate result;
				if ((result = this._OnAddTrackedFace) == null)
				{
					result = (this._OnAddTrackedFace = new FTrackableFaceDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnAddTrackedFace, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnAddTrackedFace, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x060036BD RID: 14013 RVA: 0x00053208 File Offset: 0x00051408
		// (set) Token: 0x060036BE RID: 14014 RVA: 0x00053241 File Offset: 0x00051441
		public FTrackableFaceDelegate OnUpdateTrackedFace
		{
			get
			{
				base.FastCheckIsValid();
				FTrackableFaceDelegate result;
				if ((result = this._OnUpdateTrackedFace) == null)
				{
					result = (this._OnUpdateTrackedFace = new FTrackableFaceDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnUpdateTrackedFace, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnUpdateTrackedFace, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x060036BF RID: 14015 RVA: 0x00053264 File Offset: 0x00051464
		// (set) Token: 0x060036C0 RID: 14016 RVA: 0x0005329D File Offset: 0x0005149D
		public FTrackableFaceDelegate OnRemoveTrackedFace
		{
			get
			{
				base.FastCheckIsValid();
				FTrackableFaceDelegate result;
				if ((result = this._OnRemoveTrackedFace) == null)
				{
					result = (this._OnRemoveTrackedFace = new FTrackableFaceDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnRemoveTrackedFace, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnRemoveTrackedFace, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x060036C1 RID: 14017 RVA: 0x000532C0 File Offset: 0x000514C0
		// (set) Token: 0x060036C2 RID: 14018 RVA: 0x000532F9 File Offset: 0x000514F9
		public FTrackableEnvProbeDelegate OnAddTrackedEnvProbe
		{
			get
			{
				base.FastCheckIsValid();
				FTrackableEnvProbeDelegate result;
				if ((result = this._OnAddTrackedEnvProbe) == null)
				{
					result = (this._OnAddTrackedEnvProbe = new FTrackableEnvProbeDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnAddTrackedEnvProbe, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnAddTrackedEnvProbe, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x060036C3 RID: 14019 RVA: 0x0005331C File Offset: 0x0005151C
		// (set) Token: 0x060036C4 RID: 14020 RVA: 0x00053355 File Offset: 0x00051555
		public FTrackableEnvProbeDelegate OnUpdateTrackedEnvProbe
		{
			get
			{
				base.FastCheckIsValid();
				FTrackableEnvProbeDelegate result;
				if ((result = this._OnUpdateTrackedEnvProbe) == null)
				{
					result = (this._OnUpdateTrackedEnvProbe = new FTrackableEnvProbeDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnUpdateTrackedEnvProbe, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnUpdateTrackedEnvProbe, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x060036C5 RID: 14021 RVA: 0x00053378 File Offset: 0x00051578
		// (set) Token: 0x060036C6 RID: 14022 RVA: 0x000533B1 File Offset: 0x000515B1
		public FTrackableEnvProbeDelegate OnRemoveTrackedEnvProbe
		{
			get
			{
				base.FastCheckIsValid();
				FTrackableEnvProbeDelegate result;
				if ((result = this._OnRemoveTrackedEnvProbe) == null)
				{
					result = (this._OnRemoveTrackedEnvProbe = new FTrackableEnvProbeDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnRemoveTrackedEnvProbe, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnRemoveTrackedEnvProbe, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x060036C7 RID: 14023 RVA: 0x000533D4 File Offset: 0x000515D4
		// (set) Token: 0x060036C8 RID: 14024 RVA: 0x0005340D File Offset: 0x0005160D
		public FTrackableObjectDelegate OnAddTrackedObject
		{
			get
			{
				base.FastCheckIsValid();
				FTrackableObjectDelegate result;
				if ((result = this._OnAddTrackedObject) == null)
				{
					result = (this._OnAddTrackedObject = new FTrackableObjectDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnAddTrackedObject, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnAddTrackedObject, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x060036C9 RID: 14025 RVA: 0x00053430 File Offset: 0x00051630
		// (set) Token: 0x060036CA RID: 14026 RVA: 0x00053469 File Offset: 0x00051669
		public FTrackableObjectDelegate OnUpdateTrackedObject
		{
			get
			{
				base.FastCheckIsValid();
				FTrackableObjectDelegate result;
				if ((result = this._OnUpdateTrackedObject) == null)
				{
					result = (this._OnUpdateTrackedObject = new FTrackableObjectDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnUpdateTrackedObject, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnUpdateTrackedObject, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x060036CB RID: 14027 RVA: 0x0005348C File Offset: 0x0005168C
		// (set) Token: 0x060036CC RID: 14028 RVA: 0x000534C5 File Offset: 0x000516C5
		public FTrackableObjectDelegate OnRemoveTrackedObject
		{
			get
			{
				base.FastCheckIsValid();
				FTrackableObjectDelegate result;
				if ((result = this._OnRemoveTrackedObject) == null)
				{
					result = (this._OnRemoveTrackedObject = new FTrackableObjectDelegate(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnRemoveTrackedObject, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARTrackableNotifyComponent.__PropertyOffset_OnRemoveTrackedObject, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x000534E6 File Offset: 0x000516E6
		static UARTrackableNotifyComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARTrackableNotifyComponent");
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x000534F4 File Offset: 0x000516F4
		protected UARTrackableNotifyComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400179D RID: 6045
		public new const string __ObjectPath = "/Script/AugmentedReality.ARTrackableNotifyComponent";

		// Token: 0x0400179E RID: 6046
		private static IntPtr _ClassPtr;

		// Token: 0x0400179F RID: 6047
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040017A0 RID: 6048
		internal static int __PropertyOffset_OnAddTrackedGeometry;

		// Token: 0x040017A1 RID: 6049
		[Nullable(2)]
		private FTrackableDelegate _OnAddTrackedGeometry;

		// Token: 0x040017A2 RID: 6050
		internal static int __PropertyOffset_OnUpdateTrackedGeometry;

		// Token: 0x040017A3 RID: 6051
		[Nullable(2)]
		private FTrackableDelegate _OnUpdateTrackedGeometry;

		// Token: 0x040017A4 RID: 6052
		internal static int __PropertyOffset_OnRemoveTrackedGeometry;

		// Token: 0x040017A5 RID: 6053
		[Nullable(2)]
		private FTrackableDelegate _OnRemoveTrackedGeometry;

		// Token: 0x040017A6 RID: 6054
		internal static int __PropertyOffset_OnAddTrackedPlane;

		// Token: 0x040017A7 RID: 6055
		[Nullable(2)]
		private FTrackablePlaneDelegate _OnAddTrackedPlane;

		// Token: 0x040017A8 RID: 6056
		internal static int __PropertyOffset_OnUpdateTrackedPlane;

		// Token: 0x040017A9 RID: 6057
		[Nullable(2)]
		private FTrackablePlaneDelegate _OnUpdateTrackedPlane;

		// Token: 0x040017AA RID: 6058
		internal static int __PropertyOffset_OnRemoveTrackedPlane;

		// Token: 0x040017AB RID: 6059
		[Nullable(2)]
		private FTrackablePlaneDelegate _OnRemoveTrackedPlane;

		// Token: 0x040017AC RID: 6060
		internal static int __PropertyOffset_OnAddTrackedPoint;

		// Token: 0x040017AD RID: 6061
		[Nullable(2)]
		private FTrackablePointDelegate _OnAddTrackedPoint;

		// Token: 0x040017AE RID: 6062
		internal static int __PropertyOffset_OnUpdateTrackedPoint;

		// Token: 0x040017AF RID: 6063
		[Nullable(2)]
		private FTrackablePointDelegate _OnUpdateTrackedPoint;

		// Token: 0x040017B0 RID: 6064
		internal static int __PropertyOffset_OnRemoveTrackedPoint;

		// Token: 0x040017B1 RID: 6065
		[Nullable(2)]
		private FTrackablePointDelegate _OnRemoveTrackedPoint;

		// Token: 0x040017B2 RID: 6066
		internal static int __PropertyOffset_OnAddTrackedImage;

		// Token: 0x040017B3 RID: 6067
		[Nullable(2)]
		private FTrackableImageDelegate _OnAddTrackedImage;

		// Token: 0x040017B4 RID: 6068
		internal static int __PropertyOffset_OnUpdateTrackedImage;

		// Token: 0x040017B5 RID: 6069
		[Nullable(2)]
		private FTrackableImageDelegate _OnUpdateTrackedImage;

		// Token: 0x040017B6 RID: 6070
		internal static int __PropertyOffset_OnRemoveTrackedImage;

		// Token: 0x040017B7 RID: 6071
		[Nullable(2)]
		private FTrackableImageDelegate _OnRemoveTrackedImage;

		// Token: 0x040017B8 RID: 6072
		internal static int __PropertyOffset_OnAddTrackedFace;

		// Token: 0x040017B9 RID: 6073
		[Nullable(2)]
		private FTrackableFaceDelegate _OnAddTrackedFace;

		// Token: 0x040017BA RID: 6074
		internal static int __PropertyOffset_OnUpdateTrackedFace;

		// Token: 0x040017BB RID: 6075
		[Nullable(2)]
		private FTrackableFaceDelegate _OnUpdateTrackedFace;

		// Token: 0x040017BC RID: 6076
		internal static int __PropertyOffset_OnRemoveTrackedFace;

		// Token: 0x040017BD RID: 6077
		[Nullable(2)]
		private FTrackableFaceDelegate _OnRemoveTrackedFace;

		// Token: 0x040017BE RID: 6078
		internal static int __PropertyOffset_OnAddTrackedEnvProbe;

		// Token: 0x040017BF RID: 6079
		[Nullable(2)]
		private FTrackableEnvProbeDelegate _OnAddTrackedEnvProbe;

		// Token: 0x040017C0 RID: 6080
		internal static int __PropertyOffset_OnUpdateTrackedEnvProbe;

		// Token: 0x040017C1 RID: 6081
		[Nullable(2)]
		private FTrackableEnvProbeDelegate _OnUpdateTrackedEnvProbe;

		// Token: 0x040017C2 RID: 6082
		internal static int __PropertyOffset_OnRemoveTrackedEnvProbe;

		// Token: 0x040017C3 RID: 6083
		[Nullable(2)]
		private FTrackableEnvProbeDelegate _OnRemoveTrackedEnvProbe;

		// Token: 0x040017C4 RID: 6084
		internal static int __PropertyOffset_OnAddTrackedObject;

		// Token: 0x040017C5 RID: 6085
		[Nullable(2)]
		private FTrackableObjectDelegate _OnAddTrackedObject;

		// Token: 0x040017C6 RID: 6086
		internal static int __PropertyOffset_OnUpdateTrackedObject;

		// Token: 0x040017C7 RID: 6087
		[Nullable(2)]
		private FTrackableObjectDelegate _OnUpdateTrackedObject;

		// Token: 0x040017C8 RID: 6088
		internal static int __PropertyOffset_OnRemoveTrackedObject;

		// Token: 0x040017C9 RID: 6089
		[Nullable(2)]
		private FTrackableObjectDelegate _OnRemoveTrackedObject;
	}
}
