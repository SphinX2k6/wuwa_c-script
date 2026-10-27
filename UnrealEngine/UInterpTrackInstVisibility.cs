using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CAD RID: 3245
	[UnrealObjectPath("/Script/Engine.InterpTrackInstVisibility")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UInterpTrackInstVisibility : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A421 RID: 42017 RVA: 0x000E9587 File Offset: 0x000E7787
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstVisibility._ClassPtr;
		}

		// Token: 0x0600A422 RID: 42018 RVA: 0x000E9594 File Offset: 0x000E7794
		public UInterpTrackInstVisibility() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstVisibility.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A423 RID: 42019 RVA: 0x000E95BC File Offset: 0x000E77BC
		[NullableContext(1)]
		public UInterpTrackInstVisibility(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstVisibility.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002708 RID: 9992
		// (get) Token: 0x0600A424 RID: 42020 RVA: 0x000E95EF File Offset: 0x000E77EF
		// (set) Token: 0x0600A425 RID: 42021 RVA: 0x000E9603 File Offset: 0x000E7803
		public unsafe TEnumAsByte<EVisibilityTrackAction> Action
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstVisibility.__PropertyOffset_Action);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstVisibility.__PropertyOffset_Action) = value;
			}
		}

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x0600A426 RID: 42022 RVA: 0x000E9618 File Offset: 0x000E7818
		// (set) Token: 0x0600A427 RID: 42023 RVA: 0x000E9628 File Offset: 0x000E7828
		public unsafe float LastUpdatePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstVisibility.__PropertyOffset_LastUpdatePosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstVisibility.__PropertyOffset_LastUpdatePosition) = value;
			}
		}

		// Token: 0x0600A428 RID: 42024 RVA: 0x000E9639 File Offset: 0x000E7839
		static UInterpTrackInstVisibility()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstVisibility");
		}

		// Token: 0x0600A429 RID: 42025 RVA: 0x000E9647 File Offset: 0x000E7847
		protected UInterpTrackInstVisibility(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A3B RID: 23099
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstVisibility";

		// Token: 0x04005A3C RID: 23100
		private static IntPtr _ClassPtr;

		// Token: 0x04005A3D RID: 23101
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A3E RID: 23102
		internal static int __PropertyOffset_Action;

		// Token: 0x04005A3F RID: 23103
		internal static int __PropertyOffset_LastUpdatePosition;
	}
}
