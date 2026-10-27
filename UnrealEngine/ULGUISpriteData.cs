using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020C7 RID: 8391
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUISpriteData")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class ULGUISpriteData : ULGUISpriteData_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F9B6 RID: 129462 RVA: 0x002EFF7D File Offset: 0x002EE17D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUISpriteData._ClassPtr;
		}

		// Token: 0x0601F9B7 RID: 129463 RVA: 0x002EFF8C File Offset: 0x002EE18C
		public ULGUISpriteData() : this(BuiltinUtils.AllocNativeUObject(ULGUISpriteData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F9B8 RID: 129464 RVA: 0x002EFFB4 File Offset: 0x002EE1B4
		[NullableContext(1)]
		public ULGUISpriteData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUISpriteData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C9E RID: 31902
		// (get) Token: 0x0601F9B9 RID: 129465 RVA: 0x002EFFE7 File Offset: 0x002EE1E7
		// (set) Token: 0x0601F9BA RID: 129466 RVA: 0x002EFFFB File Offset: 0x002EE1FB
		public unsafe UTexture2D spriteTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUISpriteData.__PropertyOffset_spriteTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUISpriteData.__PropertyOffset_spriteTexture, value);
			}
		}

		// Token: 0x17007C9F RID: 31903
		// (get) Token: 0x0601F9BB RID: 129467 RVA: 0x002F0010 File Offset: 0x002EE210
		// (set) Token: 0x0601F9BC RID: 129468 RVA: 0x002F0049 File Offset: 0x002EE249
		[Nullable(1)]
		public FLGUISpriteInfo spriteInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUISpriteInfo result;
				if ((result = this._spriteInfo) == null)
				{
					result = (this._spriteInfo = new FLGUISpriteInfo(base.NativePtr + (IntPtr)ULGUISpriteData.__PropertyOffset_spriteInfo, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUISpriteInfo.StaticStruct(), base.NativePtr + (IntPtr)ULGUISpriteData.__PropertyOffset_spriteInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007CA0 RID: 31904
		// (get) Token: 0x0601F9BD RID: 129469 RVA: 0x002F006A File Offset: 0x002EE26A
		// (set) Token: 0x0601F9BE RID: 129470 RVA: 0x002F007E File Offset: 0x002EE27E
		public unsafe FName packingTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUISpriteData.__PropertyOffset_packingTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUISpriteData.__PropertyOffset_packingTag) = value;
			}
		}

		// Token: 0x17007CA1 RID: 31905
		// (get) Token: 0x0601F9BF RID: 129471 RVA: 0x002F0093 File Offset: 0x002EE293
		// (set) Token: 0x0601F9C0 RID: 129472 RVA: 0x002F00A7 File Offset: 0x002EE2A7
		public unsafe UTexture2D atlasTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUISpriteData.__PropertyOffset_atlasTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUISpriteData.__PropertyOffset_atlasTexture, value);
			}
		}

		// Token: 0x0601F9C1 RID: 129473 RVA: 0x002F00BC File Offset: 0x002EE2BC
		public bool HavePackingTag()
		{
			return ULGUISpriteData.__HavePackingTag_Internal(base.NativePtr);
		}

		// Token: 0x0601F9C2 RID: 129474 RVA: 0x002F00C9 File Offset: 0x002EE2C9
		public UTexture2D GetSpriteTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(ULGUISpriteData.__GetSpriteTexture_Internal(base.NativePtr));
		}

		// Token: 0x0601F9C3 RID: 129475 RVA: 0x002F00DB File Offset: 0x002EE2DB
		public FName GetPackingTag()
		{
			return ULGUISpriteData.__GetPackingTag_Internal(base.NativePtr);
		}

		// Token: 0x0601F9C4 RID: 129476 RVA: 0x002F00E8 File Offset: 0x002EE2E8
		public static ULGUISpriteData CreateLGUISpriteData(UObject Outer, UTexture2D inSpriteTexture, FVector2D inHorizontalBorder = default(FVector2D), FVector2D inVerticalBorder = default(FVector2D), FName? inPackingTag = null)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUISpriteData>(ULGUISpriteData.__CreateLGUISpriteData_Internal((Outer != null) ? Outer.NativePtr : IntPtr.Zero, (inSpriteTexture != null) ? inSpriteTexture.NativePtr : IntPtr.Zero, inHorizontalBorder, inVerticalBorder, inPackingTag ?? new FName("Main")));
		}

		// Token: 0x0601F9C5 RID: 129477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HavePackingTag_Internal(IntPtr @this);

		// Token: 0x0601F9C6 RID: 129478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSpriteTexture_Internal(IntPtr @this);

		// Token: 0x0601F9C7 RID: 129479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetPackingTag_Internal(IntPtr @this);

		// Token: 0x0601F9C8 RID: 129480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateLGUISpriteData_Internal(IntPtr Outer, IntPtr inSpriteTexture, FVector2D inHorizontalBorder, FVector2D inVerticalBorder, FName inPackingTag);

		// Token: 0x0601F9C9 RID: 129481 RVA: 0x002F0140 File Offset: 0x002EE340
		static ULGUISpriteData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUISpriteData");
		}

		// Token: 0x0601F9CA RID: 129482 RVA: 0x002F014E File Offset: 0x002EE34E
		protected ULGUISpriteData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040110F0 RID: 69872
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUISpriteData";

		// Token: 0x040110F1 RID: 69873
		private static IntPtr _ClassPtr;

		// Token: 0x040110F2 RID: 69874
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040110F3 RID: 69875
		internal static int __PropertyOffset_spriteTexture;

		// Token: 0x040110F4 RID: 69876
		internal static int __PropertyOffset_spriteInfo;

		// Token: 0x040110F5 RID: 69877
		private FLGUISpriteInfo _spriteInfo;

		// Token: 0x040110F6 RID: 69878
		internal static int __PropertyOffset_packingTag;

		// Token: 0x040110F7 RID: 69879
		internal static int __PropertyOffset_atlasTexture;
	}
}
