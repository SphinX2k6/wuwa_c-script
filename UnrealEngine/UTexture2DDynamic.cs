using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011CF RID: 4559
	[UnrealObjectPath("/Script/Engine.Texture2DDynamic")]
	[UnrealStructLayout(3936, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3936)]
	public class UTexture2DDynamic : UTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010CFC RID: 68860 RVA: 0x0018B091 File Offset: 0x00189291
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTexture2DDynamic._ClassPtr;
		}

		// Token: 0x06010CFD RID: 68861 RVA: 0x0018B0A0 File Offset: 0x001892A0
		public UTexture2DDynamic() : this(BuiltinUtils.AllocNativeUObject(UTexture2DDynamic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010CFE RID: 68862 RVA: 0x0018B0C8 File Offset: 0x001892C8
		[NullableContext(1)]
		public UTexture2DDynamic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTexture2DDynamic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041AA RID: 16810
		// (get) Token: 0x06010CFF RID: 68863 RVA: 0x0018B0FB File Offset: 0x001892FB
		// (set) Token: 0x06010D00 RID: 68864 RVA: 0x0018B10F File Offset: 0x0018930F
		public unsafe TEnumAsByte<EPixelFormat> Format
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture2DDynamic.__PropertyOffset_Format);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture2DDynamic.__PropertyOffset_Format) = value;
			}
		}

		// Token: 0x06010D01 RID: 68865 RVA: 0x0018B124 File Offset: 0x00189324
		static UTexture2DDynamic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Texture2DDynamic");
		}

		// Token: 0x06010D02 RID: 68866 RVA: 0x0018B132 File Offset: 0x00189332
		protected UTexture2DDynamic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008FBF RID: 36799
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Texture2DDynamic";

		// Token: 0x04008FC0 RID: 36800
		private static IntPtr _ClassPtr;

		// Token: 0x04008FC1 RID: 36801
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008FC2 RID: 36802
		internal static int __PropertyOffset_Format;
	}
}
