using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CAC RID: 3244
	[UnrealObjectPath("/Script/Engine.InterpTrackInstVectorProp")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UInterpTrackInstVectorProp : UInterpTrackInstProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A41A RID: 42010 RVA: 0x000E94DF File Offset: 0x000E76DF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstVectorProp._ClassPtr;
		}

		// Token: 0x0600A41B RID: 42011 RVA: 0x000E94EC File Offset: 0x000E76EC
		public UInterpTrackInstVectorProp() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstVectorProp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A41C RID: 42012 RVA: 0x000E9514 File Offset: 0x000E7714
		[NullableContext(1)]
		public UInterpTrackInstVectorProp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstVectorProp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002707 RID: 9991
		// (get) Token: 0x0600A41D RID: 42013 RVA: 0x000E9547 File Offset: 0x000E7747
		// (set) Token: 0x0600A41E RID: 42014 RVA: 0x000E955B File Offset: 0x000E775B
		public unsafe FVector ResetVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstVectorProp.__PropertyOffset_ResetVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstVectorProp.__PropertyOffset_ResetVector) = value;
			}
		}

		// Token: 0x0600A41F RID: 42015 RVA: 0x000E9570 File Offset: 0x000E7770
		static UInterpTrackInstVectorProp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstVectorProp");
		}

		// Token: 0x0600A420 RID: 42016 RVA: 0x000E957E File Offset: 0x000E777E
		protected UInterpTrackInstVectorProp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A37 RID: 23095
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstVectorProp";

		// Token: 0x04005A38 RID: 23096
		private static IntPtr _ClassPtr;

		// Token: 0x04005A39 RID: 23097
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A3A RID: 23098
		internal static int __PropertyOffset_ResetVector;
	}
}
