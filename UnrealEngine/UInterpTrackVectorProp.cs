using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CB8 RID: 3256
	[UnrealObjectPath("/Script/Engine.InterpTrackVectorProp")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UInterpTrackVectorProp : UInterpTrackVectorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A4A0 RID: 42144 RVA: 0x000EA40F File Offset: 0x000E860F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackVectorProp._ClassPtr;
		}

		// Token: 0x0600A4A1 RID: 42145 RVA: 0x000EA41C File Offset: 0x000E861C
		public UInterpTrackVectorProp() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackVectorProp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A4A2 RID: 42146 RVA: 0x000EA444 File Offset: 0x000E8644
		[NullableContext(1)]
		public UInterpTrackVectorProp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackVectorProp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700272D RID: 10029
		// (get) Token: 0x0600A4A3 RID: 42147 RVA: 0x000EA477 File Offset: 0x000E8677
		// (set) Token: 0x0600A4A4 RID: 42148 RVA: 0x000EA48B File Offset: 0x000E868B
		public unsafe FName PropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackVectorProp.__PropertyOffset_PropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackVectorProp.__PropertyOffset_PropertyName) = value;
			}
		}

		// Token: 0x0600A4A5 RID: 42149 RVA: 0x000EA4A0 File Offset: 0x000E86A0
		static UInterpTrackVectorProp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackVectorProp");
		}

		// Token: 0x0600A4A6 RID: 42150 RVA: 0x000EA4AE File Offset: 0x000E86AE
		protected UInterpTrackVectorProp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A9B RID: 23195
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackVectorProp";

		// Token: 0x04005A9C RID: 23196
		private static IntPtr _ClassPtr;

		// Token: 0x04005A9D RID: 23197
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A9E RID: 23198
		internal static int __PropertyOffset_PropertyName;
	}
}
