using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006E9 RID: 1769
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIArtText")]
	[UnrealStructLayout(2384, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2384)]
	public class UUIArtText : UUIBatchGeometryRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060095FB RID: 38395 RVA: 0x000E25C3 File Offset: 0x000E07C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIArtText._ClassPtr;
		}

		// Token: 0x060095FC RID: 38396 RVA: 0x000E25D0 File Offset: 0x000E07D0
		public UUIArtText() : this(BuiltinUtils.AllocNativeUObject(UUIArtText.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060095FD RID: 38397 RVA: 0x000E25F8 File Offset: 0x000E07F8
		public UUIArtText(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIArtText.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x060095FE RID: 38398 RVA: 0x000E262B File Offset: 0x000E082B
		// (set) Token: 0x060095FF RID: 38399 RVA: 0x000E263F File Offset: 0x000E083F
		[Nullable(2)]
		public unsafe ULGUIArtTextData ArtTextData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIArtTextData>(base.NativePtr / (IntPtr)sizeof(void*) + UUIArtText.__PropertyOffset_ArtTextData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIArtText.__PropertyOffset_ArtTextData, value);
			}
		}

		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x06009600 RID: 38400 RVA: 0x000E2654 File Offset: 0x000E0854
		// (set) Token: 0x06009601 RID: 38401 RVA: 0x000E2668 File Offset: 0x000E0868
		public unsafe string Text
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UUIArtText.__PropertyOffset_Text)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UUIArtText.__PropertyOffset_Text)), value);
			}
		}

		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x06009602 RID: 38402 RVA: 0x000E267D File Offset: 0x000E087D
		// (set) Token: 0x06009603 RID: 38403 RVA: 0x000E268D File Offset: 0x000E088D
		public unsafe float Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIArtText.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIArtText.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x06009604 RID: 38404 RVA: 0x000E269E File Offset: 0x000E089E
		// (set) Token: 0x06009605 RID: 38405 RVA: 0x000E26B2 File Offset: 0x000E08B2
		public unsafe FVector2D Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIArtText.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIArtText.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x06009606 RID: 38406 RVA: 0x000E26C7 File Offset: 0x000E08C7
		// (set) Token: 0x06009607 RID: 38407 RVA: 0x000E26D7 File Offset: 0x000E08D7
		public unsafe bool IsWidthControlledByText
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIArtText.__PropertyOffset_IsWidthControlledByText) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIArtText.__PropertyOffset_IsWidthControlledByText) = (value ? 1 : 0);
			}
		}

		// Token: 0x06009608 RID: 38408 RVA: 0x000E26E8 File Offset: 0x000E08E8
		public unsafe void SetText(string NewText)
		{
			FString fstring = FString.AllocTemp(NewText);
			UUIArtText.__SetText_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009609 RID: 38409 RVA: 0x000E2712 File Offset: 0x000E0912
		public void SetSpace(FVector2D NewSpace)
		{
			UUIArtText.__SetSpace_Internal(base.NativePtr, NewSpace);
		}

		// Token: 0x0600960A RID: 38410 RVA: 0x000E2720 File Offset: 0x000E0920
		public void SetSize(float NewSize)
		{
			UUIArtText.__SetSize_Internal(base.NativePtr, NewSize);
		}

		// Token: 0x0600960B RID: 38411 RVA: 0x000E272E File Offset: 0x000E092E
		public void SetIsWidthControlledByText(bool NewValue)
		{
			UUIArtText.__SetIsWidthControlledByText_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600960C RID: 38412 RVA: 0x000E273C File Offset: 0x000E093C
		[NullableContext(2)]
		public void SetArtTextData(ULGUIArtTextData NewArtTextData)
		{
			UUIArtText.__SetArtTextData_Internal(base.NativePtr, (NewArtTextData != null) ? NewArtTextData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600960D RID: 38413 RVA: 0x000E2759 File Offset: 0x000E0959
		public string GetText()
		{
			return FString.ToStringAndDeleteNativePtr(UUIArtText.__GetText_Internal(base.NativePtr));
		}

		// Token: 0x0600960E RID: 38414 RVA: 0x000E276B File Offset: 0x000E096B
		public FVector2D GetSpace()
		{
			return UUIArtText.__GetSpace_Internal(base.NativePtr);
		}

		// Token: 0x0600960F RID: 38415 RVA: 0x000E2778 File Offset: 0x000E0978
		public float GetSize()
		{
			return UUIArtText.__GetSize_Internal(base.NativePtr);
		}

		// Token: 0x06009610 RID: 38416 RVA: 0x000E2785 File Offset: 0x000E0985
		public float GetIsWidthControlledByText()
		{
			return UUIArtText.__GetIsWidthControlledByText_Internal(base.NativePtr);
		}

		// Token: 0x06009611 RID: 38417 RVA: 0x000E2792 File Offset: 0x000E0992
		[NullableContext(2)]
		public ULGUIArtTextData GetArtTextData()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIArtTextData>(UUIArtText.__GetArtTextData_Internal(base.NativePtr));
		}

		// Token: 0x06009612 RID: 38418 RVA: 0x000E27A4 File Offset: 0x000E09A4
		public bool CheckTextValid()
		{
			return UUIArtText.__CheckTextValid_Internal(base.NativePtr);
		}

		// Token: 0x06009613 RID: 38419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetText_Internal(IntPtr @this, in FString NewText);

		// Token: 0x06009614 RID: 38420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpace_Internal(IntPtr @this, FVector2D NewSpace);

		// Token: 0x06009615 RID: 38421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSize_Internal(IntPtr @this, float NewSize);

		// Token: 0x06009616 RID: 38422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsWidthControlledByText_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06009617 RID: 38423
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetArtTextData_Internal(IntPtr @this, IntPtr NewArtTextData);

		// Token: 0x06009618 RID: 38424
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetText_Internal(IntPtr @this);

		// Token: 0x06009619 RID: 38425
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetSpace_Internal(IntPtr @this);

		// Token: 0x0600961A RID: 38426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSize_Internal(IntPtr @this);

		// Token: 0x0600961B RID: 38427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetIsWidthControlledByText_Internal(IntPtr @this);

		// Token: 0x0600961C RID: 38428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetArtTextData_Internal(IntPtr @this);

		// Token: 0x0600961D RID: 38429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckTextValid_Internal(IntPtr @this);

		// Token: 0x0600961E RID: 38430 RVA: 0x000E27B1 File Offset: 0x000E09B1
		static UUIArtText()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIArtText");
		}

		// Token: 0x0600961F RID: 38431 RVA: 0x000E27BF File Offset: 0x000E09BF
		protected UUIArtText(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400414A RID: 16714
		public new const string __ObjectPath = "/Script/LGUI.UIArtText";

		// Token: 0x0400414B RID: 16715
		private static IntPtr _ClassPtr;

		// Token: 0x0400414C RID: 16716
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400414D RID: 16717
		internal static int __PropertyOffset_ArtTextData;

		// Token: 0x0400414E RID: 16718
		internal static int __PropertyOffset_Text;

		// Token: 0x0400414F RID: 16719
		internal static int __PropertyOffset_Size;

		// Token: 0x04004150 RID: 16720
		internal static int __PropertyOffset_Space;

		// Token: 0x04004151 RID: 16721
		internal static int __PropertyOffset_IsWidthControlledByText;
	}
}
