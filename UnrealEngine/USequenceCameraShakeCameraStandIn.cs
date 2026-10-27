using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002904 RID: 10500
	[UnrealObjectPath("/Script/TemplateSequence.SequenceCameraShakeCameraStandIn")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class USequenceCameraShakeCameraStandIn : UObject, IUnrealUObject, IUnrealObject, IMovieSceneSceneComponentImpersonator, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06026F30 RID: 159536 RVA: 0x003B6793 File Offset: 0x003B4993
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USequenceCameraShakeCameraStandIn._ClassPtr;
		}

		// Token: 0x06026F31 RID: 159537 RVA: 0x003B679F File Offset: 0x003B499F
		int IMovieSceneSceneComponentImpersonator.InterfaceOffset()
		{
			return USequenceCameraShakeCameraStandIn.__InterfaceOffset_IMovieSceneSceneComponentImpersonator;
		}

		// Token: 0x06026F32 RID: 159538 RVA: 0x003B67A8 File Offset: 0x003B49A8
		public USequenceCameraShakeCameraStandIn() : this(BuiltinUtils.AllocNativeUObject(USequenceCameraShakeCameraStandIn.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026F33 RID: 159539 RVA: 0x003B67D0 File Offset: 0x003B49D0
		[NullableContext(1)]
		public USequenceCameraShakeCameraStandIn(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USequenceCameraShakeCameraStandIn.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009600 RID: 38400
		// (get) Token: 0x06026F34 RID: 159540 RVA: 0x003B6803 File Offset: 0x003B4A03
		// (set) Token: 0x06026F35 RID: 159541 RVA: 0x003B6813 File Offset: 0x003B4A13
		public unsafe float FieldOfView
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USequenceCameraShakeCameraStandIn.__PropertyOffset_FieldOfView);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USequenceCameraShakeCameraStandIn.__PropertyOffset_FieldOfView) = value;
			}
		}

		// Token: 0x06026F36 RID: 159542 RVA: 0x003B6824 File Offset: 0x003B4A24
		static USequenceCameraShakeCameraStandIn()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TemplateSequence.SequenceCameraShakeCameraStandIn");
		}

		// Token: 0x06026F37 RID: 159543 RVA: 0x003B6832 File Offset: 0x003B4A32
		protected USequenceCameraShakeCameraStandIn(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015604 RID: 87556
		internal static int __InterfaceOffset_IMovieSceneSceneComponentImpersonator;

		// Token: 0x04015605 RID: 87557
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TemplateSequence.SequenceCameraShakeCameraStandIn";

		// Token: 0x04015606 RID: 87558
		private static IntPtr _ClassPtr;

		// Token: 0x04015607 RID: 87559
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015608 RID: 87560
		internal static int __PropertyOffset_FieldOfView;
	}
}
