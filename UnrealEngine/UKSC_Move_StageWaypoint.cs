using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E0F RID: 7695
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_StageWaypoint")]
	[UnrealStructLayout(536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 536)]
	public class UKSC_Move_StageWaypoint : UKSC_Move_Stage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D5EB RID: 120299 RVA: 0x002B5B63 File Offset: 0x002B3D63
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_StageWaypoint._ClassPtr;
		}

		// Token: 0x0601D5EC RID: 120300 RVA: 0x002B5B70 File Offset: 0x002B3D70
		public UKSC_Move_StageWaypoint() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_StageWaypoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D5ED RID: 120301 RVA: 0x002B5B98 File Offset: 0x002B3D98
		[NullableContext(1)]
		public UKSC_Move_StageWaypoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_StageWaypoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D5EE RID: 120302 RVA: 0x002B5BCB File Offset: 0x002B3DCB
		public void StartMove()
		{
			UKSC_Move_StageWaypoint.__StartMove_Internal(base.NativePtr);
		}

		// Token: 0x0601D5EF RID: 120303 RVA: 0x002B5BD8 File Offset: 0x002B3DD8
		public void SetLoop(bool Loop)
		{
			UKSC_Move_StageWaypoint.__SetLoop_Internal(base.NativePtr, Loop);
		}

		// Token: 0x0601D5F0 RID: 120304 RVA: 0x002B5BE6 File Offset: 0x002B3DE6
		public void ClearWaypoints()
		{
			UKSC_Move_StageWaypoint.__ClearWaypoints_Internal(base.NativePtr);
		}

		// Token: 0x0601D5F1 RID: 120305 RVA: 0x002B5BF3 File Offset: 0x002B3DF3
		public void AddWaypoint(double X, double Y)
		{
			UKSC_Move_StageWaypoint.__AddWaypoint_Internal(base.NativePtr, X, Y);
		}

		// Token: 0x0601D5F2 RID: 120306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartMove_Internal(IntPtr @this);

		// Token: 0x0601D5F3 RID: 120307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLoop_Internal(IntPtr @this, bool Loop);

		// Token: 0x0601D5F4 RID: 120308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearWaypoints_Internal(IntPtr @this);

		// Token: 0x0601D5F5 RID: 120309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddWaypoint_Internal(IntPtr @this, double X, double Y);

		// Token: 0x0601D5F6 RID: 120310 RVA: 0x002B5C02 File Offset: 0x002B3E02
		static UKSC_Move_StageWaypoint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_StageWaypoint");
		}

		// Token: 0x0601D5F7 RID: 120311 RVA: 0x002B5C10 File Offset: 0x002B3E10
		protected UKSC_Move_StageWaypoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEE3 RID: 65251
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_StageWaypoint";

		// Token: 0x0400FEE4 RID: 65252
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEE5 RID: 65253
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
