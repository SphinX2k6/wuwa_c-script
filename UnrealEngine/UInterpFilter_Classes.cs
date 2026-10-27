using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C7C RID: 3196
	[UnrealObjectPath("/Script/Engine.InterpFilter_Classes")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UInterpFilter_Classes : UInterpFilter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A255 RID: 41557 RVA: 0x000E6797 File Offset: 0x000E4997
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpFilter_Classes._ClassPtr;
		}

		// Token: 0x0600A256 RID: 41558 RVA: 0x000E67A4 File Offset: 0x000E49A4
		public UInterpFilter_Classes() : this(BuiltinUtils.AllocNativeUObject(UInterpFilter_Classes.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A257 RID: 41559 RVA: 0x000E67CC File Offset: 0x000E49CC
		[NullableContext(1)]
		public UInterpFilter_Classes(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpFilter_Classes.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A258 RID: 41560 RVA: 0x000E67FF File Offset: 0x000E49FF
		static UInterpFilter_Classes()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpFilter_Classes");
		}

		// Token: 0x0600A259 RID: 41561 RVA: 0x000E680D File Offset: 0x000E4A0D
		protected UInterpFilter_Classes(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005912 RID: 22802
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpFilter_Classes";

		// Token: 0x04005913 RID: 22803
		private static IntPtr _ClassPtr;

		// Token: 0x04005914 RID: 22804
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
