using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CA5 RID: 3237
	[UnrealObjectPath("/Script/Engine.InterpTrackInstMove")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UInterpTrackInstMove : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A3D9 RID: 41945 RVA: 0x000E8EAB File Offset: 0x000E70AB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstMove._ClassPtr;
		}

		// Token: 0x0600A3DA RID: 41946 RVA: 0x000E8EB8 File Offset: 0x000E70B8
		public UInterpTrackInstMove() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstMove.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A3DB RID: 41947 RVA: 0x000E8EE0 File Offset: 0x000E70E0
		[NullableContext(1)]
		public UInterpTrackInstMove(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026F8 RID: 9976
		// (get) Token: 0x0600A3DC RID: 41948 RVA: 0x000E8F13 File Offset: 0x000E7113
		// (set) Token: 0x0600A3DD RID: 41949 RVA: 0x000E8F27 File Offset: 0x000E7127
		public unsafe FVector ResetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstMove.__PropertyOffset_ResetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstMove.__PropertyOffset_ResetLocation) = value;
			}
		}

		// Token: 0x170026F9 RID: 9977
		// (get) Token: 0x0600A3DE RID: 41950 RVA: 0x000E8F3C File Offset: 0x000E713C
		// (set) Token: 0x0600A3DF RID: 41951 RVA: 0x000E8F50 File Offset: 0x000E7150
		public unsafe FRotator ResetRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstMove.__PropertyOffset_ResetRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstMove.__PropertyOffset_ResetRotation) = value;
			}
		}

		// Token: 0x0600A3E0 RID: 41952 RVA: 0x000E8F65 File Offset: 0x000E7165
		static UInterpTrackInstMove()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstMove");
		}

		// Token: 0x0600A3E1 RID: 41953 RVA: 0x000E8F73 File Offset: 0x000E7173
		protected UInterpTrackInstMove(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A0F RID: 23055
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstMove";

		// Token: 0x04005A10 RID: 23056
		private static IntPtr _ClassPtr;

		// Token: 0x04005A11 RID: 23057
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A12 RID: 23058
		internal static int __PropertyOffset_ResetLocation;

		// Token: 0x04005A13 RID: 23059
		internal static int __PropertyOffset_ResetRotation;
	}
}
