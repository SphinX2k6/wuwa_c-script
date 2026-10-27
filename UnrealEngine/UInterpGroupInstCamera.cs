using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C83 RID: 3203
	[UnrealObjectPath("/Script/Engine.InterpGroupInstCamera")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UInterpGroupInstCamera : UInterpGroupInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A299 RID: 41625 RVA: 0x000E6E72 File Offset: 0x000E5072
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpGroupInstCamera._ClassPtr;
		}

		// Token: 0x0600A29A RID: 41626 RVA: 0x000E6E80 File Offset: 0x000E5080
		public UInterpGroupInstCamera() : this(BuiltinUtils.AllocNativeUObject(UInterpGroupInstCamera.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A29B RID: 41627 RVA: 0x000E6EA8 File Offset: 0x000E50A8
		[NullableContext(1)]
		public UInterpGroupInstCamera(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpGroupInstCamera.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A29C RID: 41628 RVA: 0x000E6EDB File Offset: 0x000E50DB
		static UInterpGroupInstCamera()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpGroupInstCamera");
		}

		// Token: 0x0600A29D RID: 41629 RVA: 0x000E6EE9 File Offset: 0x000E50E9
		protected UInterpGroupInstCamera(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400593D RID: 22845
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpGroupInstCamera";

		// Token: 0x0400593E RID: 22846
		private static IntPtr _ClassPtr;

		// Token: 0x0400593F RID: 22847
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
