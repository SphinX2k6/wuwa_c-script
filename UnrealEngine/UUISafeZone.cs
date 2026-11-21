using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200071C RID: 1820
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISafeZone")]
	[UnrealStructLayout(568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 568)]
	public class UUISafeZone : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009CA8 RID: 40104 RVA: 0x000E9D40 File Offset: 0x000E7F40
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISafeZone._ClassPtr;
		}

		// Token: 0x06009CA9 RID: 40105 RVA: 0x000E9D4C File Offset: 0x000E7F4C
		public UUISafeZone() : this(BuiltinUtils.AllocNativeUObject(UUISafeZone.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009CAA RID: 40106 RVA: 0x000E9D74 File Offset: 0x000E7F74
		public UUISafeZone(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISafeZone.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x06009CAB RID: 40107 RVA: 0x000E9DA7 File Offset: 0x000E7FA7
		// (set) Token: 0x06009CAC RID: 40108 RVA: 0x000E9DBB File Offset: 0x000E7FBB
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x06009CAD RID: 40109 RVA: 0x000E9DD0 File Offset: 0x000E7FD0
		// (set) Token: 0x06009CAE RID: 40110 RVA: 0x000E9DE4 File Offset: 0x000E7FE4
		public unsafe FMargin DefaultMargin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_DefaultMargin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_DefaultMargin) = value;
			}
		}

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x06009CAF RID: 40111 RVA: 0x000E9DF9 File Offset: 0x000E7FF9
		// (set) Token: 0x06009CB0 RID: 40112 RVA: 0x000E9E0D File Offset: 0x000E800D
		public unsafe FMargin PadMargin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_PadMargin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_PadMargin) = value;
			}
		}

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x06009CB1 RID: 40113 RVA: 0x000E9E22 File Offset: 0x000E8022
		// (set) Token: 0x06009CB2 RID: 40114 RVA: 0x000E9E36 File Offset: 0x000E8036
		public unsafe FMargin DefFoldableSquareMargin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_DefFoldableSquareMargin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_DefFoldableSquareMargin) = value;
			}
		}

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x06009CB3 RID: 40115 RVA: 0x000E9E4C File Offset: 0x000E804C
		// (set) Token: 0x06009CB4 RID: 40116 RVA: 0x000E9E85 File Offset: 0x000E8085
		public TMap<string, FMargin> CustomDeviceMargins
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FMargin> result;
				if ((result = this._CustomDeviceMargins) == null)
				{
					result = (this._CustomDeviceMargins = new TMap<string, FMargin>(base.NativePtr + (IntPtr)UUISafeZone.__PropertyOffset_CustomDeviceMargins, this));
				}
				return result;
			}
			set
			{
				this.CustomDeviceMargins.CopyAssign(value);
			}
		}

		// Token: 0x06009CB5 RID: 40117 RVA: 0x000E9E94 File Offset: 0x000E8094
		[SkipLocalsInit]
		public unsafe void SetWidthAndHeightRadio(float Left = 0f, float Right = 0f, float Top = 0f, float Bottom = 0f)
		{
			UUISafeZone.__SetWidthAndHeightRadio_FunctionParams* ptr = stackalloc UUISafeZone.__SetWidthAndHeightRadio_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UUISafeZone.__SetWidthAndHeightRadio_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UUISafeZone.__SetWidthAndHeightRadio_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Left = Left;
			ptr->Right = Right;
			ptr->Top = Top;
			ptr->Bottom = Bottom;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UUISafeZone.__SetWidthAndHeightRadio_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06009CB6 RID: 40118 RVA: 0x000E9EF0 File Offset: 0x000E80F0
		[SkipLocalsInit]
		public void ForceApplyScreenAdaptation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UUISafeZone.__ForceApplyScreenAdaptation_NativeFunctionPtr, null);
		}

		// Token: 0x06009CB7 RID: 40119 RVA: 0x000E9F04 File Offset: 0x000E8104
		static UUISafeZone()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISafeZone");
		}

		// Token: 0x06009CB8 RID: 40120 RVA: 0x000E9F12 File Offset: 0x000E8112
		protected UUISafeZone(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004388 RID: 17288
		public new const string __ObjectPath = "/Script/LGUI.UISafeZone";

		// Token: 0x04004389 RID: 17289
		private static IntPtr _ClassPtr;

		// Token: 0x0400438A RID: 17290
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400438B RID: 17291
		internal static int __PropertyOffset_Padding;

		// Token: 0x0400438C RID: 17292
		internal static int __PropertyOffset_DefaultMargin;

		// Token: 0x0400438D RID: 17293
		internal static int __PropertyOffset_PadMargin;

		// Token: 0x0400438E RID: 17294
		internal static int __PropertyOffset_DefFoldableSquareMargin;

		// Token: 0x0400438F RID: 17295
		internal static int __PropertyOffset_CustomDeviceMargins;

		// Token: 0x04004390 RID: 17296
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FMargin> _CustomDeviceMargins;

		// Token: 0x04004391 RID: 17297
		private static IntPtr __SetWidthAndHeightRadio_NativeFunctionPtr;

		// Token: 0x04004392 RID: 17298
		private static IntPtr __ForceApplyScreenAdaptation_NativeFunctionPtr;

		// Token: 0x02000F22 RID: 3874
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetWidthAndHeightRadio_FunctionParams
		{
			// Token: 0x040062F2 RID: 25330
			[FieldOffset(0)]
			public float Left;

			// Token: 0x040062F3 RID: 25331
			[FieldOffset(4)]
			public float Right;

			// Token: 0x040062F4 RID: 25332
			[FieldOffset(8)]
			public float Top;

			// Token: 0x040062F5 RID: 25333
			[FieldOffset(12)]
			public float Bottom;
		}
	}
}
