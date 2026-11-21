using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007ED RID: 2029
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestSimpleClass")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class USharpherealTestSimpleClass : UObject, IUnrealUObject, IUnrealObject, ISharpherealTestInterface, IUnrealNativeInterface, IUnrealInterface, ISharpherealTestInterface2
	{
		// Token: 0x0600ADA9 RID: 44457 RVA: 0x00101071 File Offset: 0x000FF271
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USharpherealTestSimpleClass._ClassPtr;
		}

		// Token: 0x0600ADAA RID: 44458 RVA: 0x0010107D File Offset: 0x000FF27D
		int ISharpherealTestInterface.InterfaceOffset()
		{
			return USharpherealTestSimpleClass.__InterfaceOffset_ISharpherealTestInterface;
		}

		// Token: 0x0600ADAB RID: 44459 RVA: 0x00101084 File Offset: 0x000FF284
		int ISharpherealTestInterface2.InterfaceOffset()
		{
			return USharpherealTestSimpleClass.__InterfaceOffset_ISharpherealTestInterface2;
		}

		// Token: 0x0600ADAC RID: 44460 RVA: 0x0010108C File Offset: 0x000FF28C
		public USharpherealTestSimpleClass() : this(BuiltinUtils.AllocNativeUObject(USharpherealTestSimpleClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ADAD RID: 44461 RVA: 0x001010B4 File Offset: 0x000FF2B4
		[NullableContext(1)]
		public USharpherealTestSimpleClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USharpherealTestSimpleClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x0600ADAE RID: 44462 RVA: 0x001010E7 File Offset: 0x000FF2E7
		// (set) Token: 0x0600ADAF RID: 44463 RVA: 0x001010FB File Offset: 0x000FF2FB
		public unsafe FVector Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USharpherealTestSimpleClass.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USharpherealTestSimpleClass.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x0600ADB0 RID: 44464 RVA: 0x00101110 File Offset: 0x000FF310
		// (set) Token: 0x0600ADB1 RID: 44465 RVA: 0x00101124 File Offset: 0x000FF324
		[Nullable(1)]
		public unsafe string String
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)USharpherealTestSimpleClass.__PropertyOffset_String)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)USharpherealTestSimpleClass.__PropertyOffset_String)), value);
			}
		}

		// Token: 0x0600ADB2 RID: 44466 RVA: 0x00101139 File Offset: 0x000FF339
		static USharpherealTestSimpleClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.SharpherealTestSimpleClass");
		}

		// Token: 0x0600ADB3 RID: 44467 RVA: 0x00101147 File Offset: 0x000FF347
		protected USharpherealTestSimpleClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004AEB RID: 19179
		internal static int __InterfaceOffset_ISharpherealTestInterface;

		// Token: 0x04004AEC RID: 19180
		internal static int __InterfaceOffset_ISharpherealTestInterface2;

		// Token: 0x04004AED RID: 19181
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestSimpleClass";

		// Token: 0x04004AEE RID: 19182
		private static IntPtr _ClassPtr;

		// Token: 0x04004AEF RID: 19183
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004AF0 RID: 19184
		internal static int __PropertyOffset_Vector;

		// Token: 0x04004AF1 RID: 19185
		internal static int __PropertyOffset_String;
	}
}
