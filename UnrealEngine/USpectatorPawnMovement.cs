using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001172 RID: 4466
	[UnrealObjectPath("/Script/Engine.SpectatorPawnMovement")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class USpectatorPawnMovement : UFloatingPawnMovement, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010510 RID: 66832 RVA: 0x00180922 File Offset: 0x0017EB22
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpectatorPawnMovement._ClassPtr;
		}

		// Token: 0x06010511 RID: 66833 RVA: 0x00180930 File Offset: 0x0017EB30
		public USpectatorPawnMovement() : this(BuiltinUtils.AllocNativeUObject(USpectatorPawnMovement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010512 RID: 66834 RVA: 0x00180958 File Offset: 0x0017EB58
		[NullableContext(1)]
		public USpectatorPawnMovement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpectatorPawnMovement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FEC RID: 16364
		// (get) Token: 0x06010513 RID: 66835 RVA: 0x0018098B File Offset: 0x0017EB8B
		// (set) Token: 0x06010514 RID: 66836 RVA: 0x001809A4 File Offset: 0x0017EBA4
		public unsafe bool bIgnoreTimeDilation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpectatorPawnMovement.__PropertyOffset_bIgnoreTimeDilation) & USpectatorPawnMovement.__PropertyMask_bIgnoreTimeDilation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpectatorPawnMovement.__PropertyOffset_bIgnoreTimeDilation) = ((*(base.NativePtr + (IntPtr)USpectatorPawnMovement.__PropertyOffset_bIgnoreTimeDilation) & ~USpectatorPawnMovement.__PropertyMask_bIgnoreTimeDilation) | (value ? USpectatorPawnMovement.__PropertyMask_bIgnoreTimeDilation : 0));
			}
		}

		// Token: 0x06010515 RID: 66837 RVA: 0x001809D4 File Offset: 0x0017EBD4
		static USpectatorPawnMovement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SpectatorPawnMovement");
		}

		// Token: 0x06010516 RID: 66838 RVA: 0x001809E2 File Offset: 0x0017EBE2
		protected USpectatorPawnMovement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008C68 RID: 35944
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SpectatorPawnMovement";

		// Token: 0x04008C69 RID: 35945
		private static IntPtr _ClassPtr;

		// Token: 0x04008C6A RID: 35946
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008C6B RID: 35947
		internal static int __PropertyOffset_bIgnoreTimeDilation;

		// Token: 0x04008C6C RID: 35948
		internal static byte __PropertyMask_bIgnoreTimeDilation;
	}
}
