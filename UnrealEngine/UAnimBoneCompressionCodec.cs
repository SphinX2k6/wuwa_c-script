using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007F0 RID: 2032
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimBoneCompressionCodec")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UAnimBoneCompressionCodec : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006C78 RID: 27768 RVA: 0x0009C051 File Offset: 0x0009A251
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimBoneCompressionCodec._ClassPtr;
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x06006C79 RID: 27769 RVA: 0x0009C05D File Offset: 0x0009A25D
		// (set) Token: 0x06006C7A RID: 27770 RVA: 0x0009C071 File Offset: 0x0009A271
		public unsafe string Description
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAnimBoneCompressionCodec.__PropertyOffset_Description)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAnimBoneCompressionCodec.__PropertyOffset_Description)), value);
			}
		}

		// Token: 0x06006C7B RID: 27771 RVA: 0x0009C086 File Offset: 0x0009A286
		static UAnimBoneCompressionCodec()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimBoneCompressionCodec");
		}

		// Token: 0x06006C7C RID: 27772 RVA: 0x0009C094 File Offset: 0x0009A294
		protected UAnimBoneCompressionCodec() : this(BuiltinUtils.AllocNativeUObject(UAnimBoneCompressionCodec.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006C7D RID: 27773 RVA: 0x0009C0BC File Offset: 0x0009A2BC
		protected UAnimBoneCompressionCodec(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400343B RID: 13371
		public new const string __ObjectPath = "/Script/Engine.AnimBoneCompressionCodec";

		// Token: 0x0400343C RID: 13372
		private static IntPtr _ClassPtr;

		// Token: 0x0400343D RID: 13373
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400343E RID: 13374
		internal static int __PropertyOffset_Description;
	}
}
