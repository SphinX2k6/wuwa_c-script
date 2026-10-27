using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C81 RID: 3201
	[UnrealObjectPath("/Script/Engine.InterpGroupDirector")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UInterpGroupDirector : UInterpGroup, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A289 RID: 41609 RVA: 0x000E6CD8 File Offset: 0x000E4ED8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpGroupDirector._ClassPtr;
		}

		// Token: 0x0600A28A RID: 41610 RVA: 0x000E6CE4 File Offset: 0x000E4EE4
		public UInterpGroupDirector() : this(BuiltinUtils.AllocNativeUObject(UInterpGroupDirector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A28B RID: 41611 RVA: 0x000E6D0C File Offset: 0x000E4F0C
		[NullableContext(1)]
		public UInterpGroupDirector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpGroupDirector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A28C RID: 41612 RVA: 0x000E6D3F File Offset: 0x000E4F3F
		static UInterpGroupDirector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpGroupDirector");
		}

		// Token: 0x0600A28D RID: 41613 RVA: 0x000E6D4D File Offset: 0x000E4F4D
		protected UInterpGroupDirector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005933 RID: 22835
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpGroupDirector";

		// Token: 0x04005934 RID: 22836
		private static IntPtr _ClassPtr;

		// Token: 0x04005935 RID: 22837
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
