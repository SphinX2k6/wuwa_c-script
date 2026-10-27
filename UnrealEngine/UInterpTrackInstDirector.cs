using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C9D RID: 3229
	[UnrealObjectPath("/Script/Engine.InterpTrackInstDirector")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UInterpTrackInstDirector : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A39B RID: 41883 RVA: 0x000E88B2 File Offset: 0x000E6AB2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstDirector._ClassPtr;
		}

		// Token: 0x0600A39C RID: 41884 RVA: 0x000E88C0 File Offset: 0x000E6AC0
		public UInterpTrackInstDirector() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstDirector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A39D RID: 41885 RVA: 0x000E88E8 File Offset: 0x000E6AE8
		[NullableContext(1)]
		public UInterpTrackInstDirector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstDirector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026ED RID: 9965
		// (get) Token: 0x0600A39E RID: 41886 RVA: 0x000E891B File Offset: 0x000E6B1B
		// (set) Token: 0x0600A39F RID: 41887 RVA: 0x000E892F File Offset: 0x000E6B2F
		[Nullable(2)]
		public unsafe AActor OldViewTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UInterpTrackInstDirector.__PropertyOffset_OldViewTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInterpTrackInstDirector.__PropertyOffset_OldViewTarget, value);
			}
		}

		// Token: 0x0600A3A0 RID: 41888 RVA: 0x000E8944 File Offset: 0x000E6B44
		static UInterpTrackInstDirector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstDirector");
		}

		// Token: 0x0600A3A1 RID: 41889 RVA: 0x000E8952 File Offset: 0x000E6B52
		protected UInterpTrackInstDirector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059E9 RID: 23017
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstDirector";

		// Token: 0x040059EA RID: 23018
		private static IntPtr _ClassPtr;

		// Token: 0x040059EB RID: 23019
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040059EC RID: 23020
		internal static int __PropertyOffset_OldViewTarget;
	}
}
