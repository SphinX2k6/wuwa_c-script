using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001146 RID: 4422
	[UnrealObjectPath("/Script/Engine.SoundNodeMature")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class USoundNodeMature : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010297 RID: 66199 RVA: 0x0017D094 File Offset: 0x0017B294
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeMature._ClassPtr;
		}

		// Token: 0x06010298 RID: 66200 RVA: 0x0017D0A0 File Offset: 0x0017B2A0
		public USoundNodeMature() : this(BuiltinUtils.AllocNativeUObject(USoundNodeMature.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010299 RID: 66201 RVA: 0x0017D0C8 File Offset: 0x0017B2C8
		[NullableContext(1)]
		public USoundNodeMature(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeMature.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601029A RID: 66202 RVA: 0x0017D0FB File Offset: 0x0017B2FB
		static USoundNodeMature()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeMature");
		}

		// Token: 0x0601029B RID: 66203 RVA: 0x0017D109 File Offset: 0x0017B309
		protected USoundNodeMature(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B1E RID: 35614
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundNodeMature";

		// Token: 0x04008B1F RID: 35615
		private static IntPtr _ClassPtr;

		// Token: 0x04008B20 RID: 35616
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
