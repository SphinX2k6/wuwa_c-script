using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C7D RID: 3197
	[UnrealObjectPath("/Script/Engine.InterpFilter_Custom")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UInterpFilter_Custom : UInterpFilter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A25A RID: 41562 RVA: 0x000E6816 File Offset: 0x000E4A16
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpFilter_Custom._ClassPtr;
		}

		// Token: 0x0600A25B RID: 41563 RVA: 0x000E6824 File Offset: 0x000E4A24
		public UInterpFilter_Custom() : this(BuiltinUtils.AllocNativeUObject(UInterpFilter_Custom.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A25C RID: 41564 RVA: 0x000E684C File Offset: 0x000E4A4C
		[NullableContext(1)]
		public UInterpFilter_Custom(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpFilter_Custom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A25D RID: 41565 RVA: 0x000E687F File Offset: 0x000E4A7F
		static UInterpFilter_Custom()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpFilter_Custom");
		}

		// Token: 0x0600A25E RID: 41566 RVA: 0x000E688D File Offset: 0x000E4A8D
		protected UInterpFilter_Custom(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005915 RID: 22805
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpFilter_Custom";

		// Token: 0x04005916 RID: 22806
		private static IntPtr _ClassPtr;

		// Token: 0x04005917 RID: 22807
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
