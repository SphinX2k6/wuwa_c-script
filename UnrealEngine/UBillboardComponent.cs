using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008AC RID: 2220
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BillboardComponent")]
	[UnrealStructLayout(1680, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class UBillboardComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600795D RID: 31069 RVA: 0x000ADAB7 File Offset: 0x000ABCB7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBillboardComponent._ClassPtr;
		}

		// Token: 0x0600795E RID: 31070 RVA: 0x000ADAC4 File Offset: 0x000ABCC4
		public UBillboardComponent() : this(BuiltinUtils.AllocNativeUObject(UBillboardComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600795F RID: 31071 RVA: 0x000ADAEC File Offset: 0x000ABCEC
		[NullableContext(1)]
		public UBillboardComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBillboardComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x06007960 RID: 31072 RVA: 0x000ADB1F File Offset: 0x000ABD1F
		// (set) Token: 0x06007961 RID: 31073 RVA: 0x000ADB33 File Offset: 0x000ABD33
		public unsafe UTexture2D Sprite
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UBillboardComponent.__PropertyOffset_Sprite);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBillboardComponent.__PropertyOffset_Sprite, value);
			}
		}

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x06007962 RID: 31074 RVA: 0x000ADB48 File Offset: 0x000ABD48
		// (set) Token: 0x06007963 RID: 31075 RVA: 0x000ADB61 File Offset: 0x000ABD61
		public unsafe bool bIsScreenSizeScaled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_bIsScreenSizeScaled) & UBillboardComponent.__PropertyMask_bIsScreenSizeScaled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_bIsScreenSizeScaled) = ((*(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_bIsScreenSizeScaled) & ~UBillboardComponent.__PropertyMask_bIsScreenSizeScaled) | (value ? UBillboardComponent.__PropertyMask_bIsScreenSizeScaled : 0));
			}
		}

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x06007964 RID: 31076 RVA: 0x000ADB91 File Offset: 0x000ABD91
		// (set) Token: 0x06007965 RID: 31077 RVA: 0x000ADBA1 File Offset: 0x000ABDA1
		public unsafe float ScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_ScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_ScreenSize) = value;
			}
		}

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x06007966 RID: 31078 RVA: 0x000ADBB2 File Offset: 0x000ABDB2
		// (set) Token: 0x06007967 RID: 31079 RVA: 0x000ADBC2 File Offset: 0x000ABDC2
		public unsafe float U
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_U);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_U) = value;
			}
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x06007968 RID: 31080 RVA: 0x000ADBD3 File Offset: 0x000ABDD3
		// (set) Token: 0x06007969 RID: 31081 RVA: 0x000ADBE3 File Offset: 0x000ABDE3
		public unsafe float UL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_UL);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_UL) = value;
			}
		}

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x0600796A RID: 31082 RVA: 0x000ADBF4 File Offset: 0x000ABDF4
		// (set) Token: 0x0600796B RID: 31083 RVA: 0x000ADC04 File Offset: 0x000ABE04
		public unsafe float V
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_V);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_V) = value;
			}
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x0600796C RID: 31084 RVA: 0x000ADC15 File Offset: 0x000ABE15
		// (set) Token: 0x0600796D RID: 31085 RVA: 0x000ADC25 File Offset: 0x000ABE25
		public unsafe float VL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_VL);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBillboardComponent.__PropertyOffset_VL) = value;
			}
		}

		// Token: 0x0600796E RID: 31086 RVA: 0x000ADC36 File Offset: 0x000ABE36
		public void SetUV(int NewU, int NewUL, int NewV, int NewVL)
		{
			UBillboardComponent.__SetUV_Internal(base.NativePtr, NewU, NewUL, NewV, NewVL);
		}

		// Token: 0x0600796F RID: 31087 RVA: 0x000ADC48 File Offset: 0x000ABE48
		public void SetSpriteAndUV(UTexture2D NewSprite, int NewU, int NewUL, int NewV, int NewVL)
		{
			UBillboardComponent.__SetSpriteAndUV_Internal(base.NativePtr, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero, NewU, NewUL, NewV, NewVL);
		}

		// Token: 0x06007970 RID: 31088 RVA: 0x000ADC6B File Offset: 0x000ABE6B
		public void SetSprite(UTexture2D NewSprite)
		{
			UBillboardComponent.__SetSprite_Internal(base.NativePtr, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007971 RID: 31089
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUV_Internal(IntPtr @this, int NewU, int NewUL, int NewV, int NewVL);

		// Token: 0x06007972 RID: 31090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpriteAndUV_Internal(IntPtr @this, IntPtr NewSprite, int NewU, int NewUL, int NewV, int NewVL);

		// Token: 0x06007973 RID: 31091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSprite_Internal(IntPtr @this, IntPtr NewSprite);

		// Token: 0x06007974 RID: 31092 RVA: 0x000ADC88 File Offset: 0x000ABE88
		static UBillboardComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BillboardComponent");
		}

		// Token: 0x06007975 RID: 31093 RVA: 0x000ADC96 File Offset: 0x000ABE96
		protected UBillboardComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A54 RID: 14932
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BillboardComponent";

		// Token: 0x04003A55 RID: 14933
		private static IntPtr _ClassPtr;

		// Token: 0x04003A56 RID: 14934
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003A57 RID: 14935
		internal static int __PropertyOffset_Sprite;

		// Token: 0x04003A58 RID: 14936
		internal static int __PropertyOffset_bIsScreenSizeScaled;

		// Token: 0x04003A59 RID: 14937
		internal static byte __PropertyMask_bIsScreenSizeScaled;

		// Token: 0x04003A5A RID: 14938
		internal static int __PropertyOffset_ScreenSize;

		// Token: 0x04003A5B RID: 14939
		internal static int __PropertyOffset_U;

		// Token: 0x04003A5C RID: 14940
		internal static int __PropertyOffset_UL;

		// Token: 0x04003A5D RID: 14941
		internal static int __PropertyOffset_V;

		// Token: 0x04003A5E RID: 14942
		internal static int __PropertyOffset_VL;
	}
}
