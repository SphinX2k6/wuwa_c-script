using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200090F RID: 2319
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CameraModifier_CameraShake")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UCameraModifier_CameraShake : UCameraModifier, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007FA3 RID: 32675 RVA: 0x000B6F3F File Offset: 0x000B513F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCameraModifier_CameraShake._ClassPtr;
		}

		// Token: 0x06007FA4 RID: 32676 RVA: 0x000B6F4C File Offset: 0x000B514C
		public UCameraModifier_CameraShake() : this(BuiltinUtils.AllocNativeUObject(UCameraModifier_CameraShake.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007FA5 RID: 32677 RVA: 0x000B6F74 File Offset: 0x000B5174
		public UCameraModifier_CameraShake(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCameraModifier_CameraShake.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x06007FA6 RID: 32678 RVA: 0x000B6FA8 File Offset: 0x000B51A8
		// (set) Token: 0x06007FA7 RID: 32679 RVA: 0x000B6FE1 File Offset: 0x000B51E1
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

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x06007FA8 RID: 32680 RVA: 0x000B6FF0 File Offset: 0x000B51F0
		// (set) Token: 0x06007FA9 RID: 32681 RVA: 0x000B7029 File Offset: 0x000B5229
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public TMap<TSubclassOf<UCameraShakeBase>, FPooledCameraShakes> ExpiredPooledShakesMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TSubclassOf<UCameraShakeBase>, FPooledCameraShakes> result;
				if ((result = this._ExpiredPooledShakesMap) == null)
				{
					result = (this._ExpiredPooledShakesMap = new TMap<TSubclassOf<UCameraShakeBase>, FPooledCameraShakes>(base.NativePtr + (IntPtr)UCameraModifier_CameraShake.__PropertyOffset_ExpiredPooledShakesMap, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			set
			{
				this.ExpiredPooledShakesMap.CopyAssign(value);
			}
		}

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x06007FAA RID: 32682 RVA: 0x000B7037 File Offset: 0x000B5237
		// (set) Token: 0x06007FAB RID: 32683 RVA: 0x000B7047 File Offset: 0x000B5247
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

		// Token: 0x06007FAC RID: 32684 RVA: 0x000B7058 File Offset: 0x000B5258
		static UCameraModifier_CameraShake()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CameraModifier_CameraShake");
		}

		// Token: 0x06007FAD RID: 32685 RVA: 0x000B7066 File Offset: 0x000B5266
		protected UCameraModifier_CameraShake(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D2F RID: 15663
		public new const string __ObjectPath = "/Script/Engine.CameraModifier_CameraShake";

		// Token: 0x04003D30 RID: 15664
		private static IntPtr _ClassPtr;

		// Token: 0x04003D31 RID: 15665
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003D32 RID: 15666
		internal static int __PropertyOffset_ActiveShakes;

		// Token: 0x04003D33 RID: 15667
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FActiveCameraShakeInfo> _ActiveShakes;

		// Token: 0x04003D34 RID: 15668
		internal static int __PropertyOffset_ExpiredPooledShakesMap;

		// Token: 0x04003D35 RID: 15669
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TSubclassOf<UCameraShakeBase>, FPooledCameraShakes> _ExpiredPooledShakesMap;

		// Token: 0x04003D36 RID: 15670
		internal static int __PropertyOffset_SplitScreenShakeScale;
	}
}
