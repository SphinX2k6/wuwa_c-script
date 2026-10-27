using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002193 RID: 8595
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UINumberLerpComponent")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UUINumberLerpComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020977 RID: 133495 RVA: 0x00304085 File Offset: 0x00302285
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUINumberLerpComponent._ClassPtr;
		}

		// Token: 0x06020978 RID: 133496 RVA: 0x00304094 File Offset: 0x00302294
		public UUINumberLerpComponent() : this(BuiltinUtils.AllocNativeUObject(UUINumberLerpComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020979 RID: 133497 RVA: 0x003040BC File Offset: 0x003022BC
		public UUINumberLerpComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUINumberLerpComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F70 RID: 32624
		// (get) Token: 0x0602097A RID: 133498 RVA: 0x003040EF File Offset: 0x003022EF
		// (set) Token: 0x0602097B RID: 133499 RVA: 0x003040FF File Offset: 0x003022FF
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINumberLerpComponent.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINumberLerpComponent.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17007F71 RID: 32625
		// (get) Token: 0x0602097C RID: 133500 RVA: 0x00304110 File Offset: 0x00302310
		// (set) Token: 0x0602097D RID: 133501 RVA: 0x00304124 File Offset: 0x00302324
		public unsafe string PrefixContent
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UUINumberLerpComponent.__PropertyOffset_PrefixContent)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UUINumberLerpComponent.__PropertyOffset_PrefixContent)), value);
			}
		}

		// Token: 0x17007F72 RID: 32626
		// (get) Token: 0x0602097E RID: 133502 RVA: 0x00304139 File Offset: 0x00302339
		// (set) Token: 0x0602097F RID: 133503 RVA: 0x0030414D File Offset: 0x0030234D
		public unsafe string PostfixContent
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UUINumberLerpComponent.__PropertyOffset_PostfixContent)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UUINumberLerpComponent.__PropertyOffset_PostfixContent)), value);
			}
		}

		// Token: 0x17007F73 RID: 32627
		// (get) Token: 0x06020980 RID: 133504 RVA: 0x00304162 File Offset: 0x00302362
		// (set) Token: 0x06020981 RID: 133505 RVA: 0x00304172 File Offset: 0x00302372
		public unsafe ENumberShowType NumberShowType
		{
			get
			{
				return (ENumberShowType)(*(base.NativePtr + (IntPtr)UUINumberLerpComponent.__PropertyOffset_NumberShowType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINumberLerpComponent.__PropertyOffset_NumberShowType) = (byte)value;
			}
		}

		// Token: 0x17007F74 RID: 32628
		// (get) Token: 0x06020982 RID: 133506 RVA: 0x00304183 File Offset: 0x00302383
		// (set) Token: 0x06020983 RID: 133507 RVA: 0x00304197 File Offset: 0x00302397
		[Nullable(2)]
		public unsafe UUIText UIText
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIText>(base.NativePtr / (IntPtr)sizeof(void*) + UUINumberLerpComponent.__PropertyOffset_UIText);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUINumberLerpComponent.__PropertyOffset_UIText, value);
			}
		}

		// Token: 0x06020984 RID: 133508 RVA: 0x003041AC File Offset: 0x003023AC
		public void SetValue(float InValue)
		{
			UUINumberLerpComponent.__SetValue_Internal(base.NativePtr, InValue);
		}

		// Token: 0x06020985 RID: 133509 RVA: 0x003041BC File Offset: 0x003023BC
		public unsafe void SetPrefixContent(string InPrefixContent)
		{
			FString fstring = FString.AllocTemp(InPrefixContent);
			UUINumberLerpComponent.__SetPrefixContent_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06020986 RID: 133510 RVA: 0x003041E8 File Offset: 0x003023E8
		public unsafe void SetPostfixContent(string InPostfixContent)
		{
			FString fstring = FString.AllocTemp(InPostfixContent);
			UUINumberLerpComponent.__SetPostfixContent_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06020987 RID: 133511 RVA: 0x00304212 File Offset: 0x00302412
		public void SetNumberShowType(ENumberShowType InNumberShowType)
		{
			UUINumberLerpComponent.__SetNumberShowType_Internal(base.NativePtr, InNumberShowType);
		}

		// Token: 0x06020988 RID: 133512 RVA: 0x00304220 File Offset: 0x00302420
		public float GetValue()
		{
			return UUINumberLerpComponent.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x06020989 RID: 133513 RVA: 0x0030422D File Offset: 0x0030242D
		public ENumberShowType GetNumberShowType()
		{
			return UUINumberLerpComponent.__GetNumberShowType_Internal(base.NativePtr);
		}

		// Token: 0x0602098A RID: 133514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValue_Internal(IntPtr @this, float InValue);

		// Token: 0x0602098B RID: 133515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPrefixContent_Internal(IntPtr @this, in FString InPrefixContent);

		// Token: 0x0602098C RID: 133516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPostfixContent_Internal(IntPtr @this, in FString InPostfixContent);

		// Token: 0x0602098D RID: 133517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNumberShowType_Internal(IntPtr @this, ENumberShowType InNumberShowType);

		// Token: 0x0602098E RID: 133518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetValue_Internal(IntPtr @this);

		// Token: 0x0602098F RID: 133519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ENumberShowType __GetNumberShowType_Internal(IntPtr @this);

		// Token: 0x06020990 RID: 133520 RVA: 0x0030423A File Offset: 0x0030243A
		static UUINumberLerpComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UINumberLerpComponent");
		}

		// Token: 0x06020991 RID: 133521 RVA: 0x00304248 File Offset: 0x00302448
		protected UUINumberLerpComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011726 RID: 71462
		public new const string __ObjectPath = "/Script/LGUI.UINumberLerpComponent";

		// Token: 0x04011727 RID: 71463
		private static IntPtr _ClassPtr;

		// Token: 0x04011728 RID: 71464
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011729 RID: 71465
		internal static int __PropertyOffset_Value;

		// Token: 0x0401172A RID: 71466
		internal static int __PropertyOffset_PrefixContent;

		// Token: 0x0401172B RID: 71467
		internal static int __PropertyOffset_PostfixContent;

		// Token: 0x0401172C RID: 71468
		internal static int __PropertyOffset_NumberShowType;

		// Token: 0x0401172D RID: 71469
		internal static int __PropertyOffset_UIText;
	}
}
