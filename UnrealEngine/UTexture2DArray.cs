using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011CE RID: 4558
	[UnrealObjectPath("/Script/Engine.Texture2DArray")]
	[UnrealStructLayout(4032, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4032)]
	public class UTexture2DArray : UTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010CF1 RID: 68849 RVA: 0x0018AF95 File Offset: 0x00189195
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTexture2DArray._ClassPtr;
		}

		// Token: 0x06010CF2 RID: 68850 RVA: 0x0018AFA4 File Offset: 0x001891A4
		public UTexture2DArray() : this(BuiltinUtils.AllocNativeUObject(UTexture2DArray.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010CF3 RID: 68851 RVA: 0x0018AFCC File Offset: 0x001891CC
		[NullableContext(1)]
		public UTexture2DArray(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTexture2DArray.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041A7 RID: 16807
		// (get) Token: 0x06010CF4 RID: 68852 RVA: 0x0018AFFF File Offset: 0x001891FF
		// (set) Token: 0x06010CF5 RID: 68853 RVA: 0x0018B013 File Offset: 0x00189213
		public unsafe TEnumAsByte<TextureAddress> AddressX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture2DArray.__PropertyOffset_AddressX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture2DArray.__PropertyOffset_AddressX) = value;
			}
		}

		// Token: 0x170041A8 RID: 16808
		// (get) Token: 0x06010CF6 RID: 68854 RVA: 0x0018B028 File Offset: 0x00189228
		// (set) Token: 0x06010CF7 RID: 68855 RVA: 0x0018B03C File Offset: 0x0018923C
		public unsafe TEnumAsByte<TextureAddress> AddressY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture2DArray.__PropertyOffset_AddressY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture2DArray.__PropertyOffset_AddressY) = value;
			}
		}

		// Token: 0x170041A9 RID: 16809
		// (get) Token: 0x06010CF8 RID: 68856 RVA: 0x0018B051 File Offset: 0x00189251
		// (set) Token: 0x06010CF9 RID: 68857 RVA: 0x0018B065 File Offset: 0x00189265
		public unsafe TEnumAsByte<TextureAddress> AddressZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture2DArray.__PropertyOffset_AddressZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture2DArray.__PropertyOffset_AddressZ) = value;
			}
		}

		// Token: 0x06010CFA RID: 68858 RVA: 0x0018B07A File Offset: 0x0018927A
		static UTexture2DArray()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Texture2DArray");
		}

		// Token: 0x06010CFB RID: 68859 RVA: 0x0018B088 File Offset: 0x00189288
		protected UTexture2DArray(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008FB9 RID: 36793
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Texture2DArray";

		// Token: 0x04008FBA RID: 36794
		private static IntPtr _ClassPtr;

		// Token: 0x04008FBB RID: 36795
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008FBC RID: 36796
		internal static int __PropertyOffset_AddressX;

		// Token: 0x04008FBD RID: 36797
		internal static int __PropertyOffset_AddressY;

		// Token: 0x04008FBE RID: 36798
		internal static int __PropertyOffset_AddressZ;
	}
}
