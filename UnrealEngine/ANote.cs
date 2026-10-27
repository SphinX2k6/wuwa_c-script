using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EF7 RID: 3831
	[UnrealObjectPath("/Script/Engine.Note")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class ANote : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CFA9 RID: 53161 RVA: 0x0012EDBF File Offset: 0x0012CFBF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANote._ClassPtr;
		}

		// Token: 0x0600CFAA RID: 53162 RVA: 0x0012EDCC File Offset: 0x0012CFCC
		public ANote() : this(BuiltinUtils.AllocNativeUObject(ANote.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CFAB RID: 53163 RVA: 0x0012EDF4 File Offset: 0x0012CFF4
		[NullableContext(1)]
		public ANote(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANote.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600CFAC RID: 53164 RVA: 0x0012EE27 File Offset: 0x0012D027
		static ANote()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Note");
		}

		// Token: 0x0600CFAD RID: 53165 RVA: 0x0012EE35 File Offset: 0x0012D035
		protected ANote(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006FF1 RID: 28657
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Note";

		// Token: 0x04006FF2 RID: 28658
		private static IntPtr _ClassPtr;

		// Token: 0x04006FF3 RID: 28659
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
