using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000169 RID: 361
	[UnrealObjectPath("/Script/AIModule.CrowdFollowingComponent")]
	[UnrealStructLayout(744, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 744)]
	public class UCrowdFollowingComponent : UPathFollowingComponent, IUnrealUObject, IUnrealObject, ICrowdAgentInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06001867 RID: 6247 RVA: 0x00023EFB File Offset: 0x000220FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCrowdFollowingComponent._ClassPtr;
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00023F07 File Offset: 0x00022107
		int ICrowdAgentInterface.InterfaceOffset()
		{
			return UCrowdFollowingComponent.__InterfaceOffset_ICrowdAgentInterface;
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00023F10 File Offset: 0x00022110
		public UCrowdFollowingComponent() : this(BuiltinUtils.AllocNativeUObject(UCrowdFollowingComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00023F38 File Offset: 0x00022138
		[NullableContext(1)]
		public UCrowdFollowingComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCrowdFollowingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x0600186B RID: 6251 RVA: 0x00023F6B File Offset: 0x0002216B
		// (set) Token: 0x0600186C RID: 6252 RVA: 0x00023F7F File Offset: 0x0002217F
		public unsafe FVector CrowdAgentMoveDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCrowdFollowingComponent.__PropertyOffset_CrowdAgentMoveDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCrowdFollowingComponent.__PropertyOffset_CrowdAgentMoveDirection) = value;
			}
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00023F94 File Offset: 0x00022194
		public void SuspendCrowdSteering(bool bSuspend)
		{
			UCrowdFollowingComponent.__SuspendCrowdSteering_Internal(base.NativePtr, bSuspend);
		}

		// Token: 0x0600186E RID: 6254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SuspendCrowdSteering_Internal(IntPtr @this, bool bSuspend);

		// Token: 0x0600186F RID: 6255 RVA: 0x00023FA2 File Offset: 0x000221A2
		static UCrowdFollowingComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.CrowdFollowingComponent");
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00023FB0 File Offset: 0x000221B0
		protected UCrowdFollowingComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000621 RID: 1569
		internal static int __InterfaceOffset_ICrowdAgentInterface;

		// Token: 0x04000622 RID: 1570
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.CrowdFollowingComponent";

		// Token: 0x04000623 RID: 1571
		private static IntPtr _ClassPtr;

		// Token: 0x04000624 RID: 1572
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000625 RID: 1573
		internal static int __PropertyOffset_CrowdAgentMoveDirection;
	}
}
