using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200019B RID: 411
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CameraModifier_CameraShake")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UCameraModifier_CameraShake : UCameraModifier, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001BCB RID: 7115 RVA: 0x0002947B File Offset: 0x0002767B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCameraModifier_CameraShake._ClassPtr;
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00029488 File Offset: 0x00027688
		public UCameraModifier_CameraShake() : this(BuiltinUtils.AllocNativeUObject(UCameraModifier_CameraShake.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x000294B0 File Offset: 0x000276B0
		public UCameraModifier_CameraShake(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCameraModifier_CameraShake.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x000294E4 File Offset: 0x000276E4
		// (set) Token: 0x06001BCF RID: 7119 RVA: 0x0002951D File Offset: 0x0002771D
		public TArray<FActiveCameraShakeInfo> ActiveShakes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FActiveCameraShakeInfo> result;
				if ((result = this._ActiveShakes) == null)
				{
					result = (this._ActiveShakes = new TArray<FActiveCameraShakeInfo>(base.NativePtr + (IntPtr)UCameraModifier_CameraShake.__PropertyOffset_ActiveShakes, this));
				}
				return result;
			}
			set
			{
				this.ActiveShakes.CopyAssign(value);
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x0002952B File Offset: 0x0002772B
		// (set) Token: 0x06001BD1 RID: 7121 RVA: 0x0002953B File Offset: 0x0002773B
		public unsafe float SplitScreenShakeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraModifier_CameraShake.__PropertyOffset_SplitScreenShakeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraModifier_CameraShake.__PropertyOffset_SplitScreenShakeScale) = value;
			}
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0002954C File Offset: 0x0002774C
		static UCameraModifier_CameraShake()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CameraModifier_CameraShake");
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0002955A File Offset: 0x0002775A
		protected UCameraModifier_CameraShake(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000907 RID: 2311
		public new const string __ObjectPath = "/Script/Engine.CameraModifier_CameraShake";

		// Token: 0x04000908 RID: 2312
		private static IntPtr _ClassPtr;

		// Token: 0x04000909 RID: 2313
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400090A RID: 2314
		internal static int __PropertyOffset_ActiveShakes;

		// Token: 0x0400090B RID: 2315
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FActiveCameraShakeInfo> _ActiveShakes;

		// Token: 0x0400090C RID: 2316
		internal static int __PropertyOffset_SplitScreenShakeScale;
	}
}
