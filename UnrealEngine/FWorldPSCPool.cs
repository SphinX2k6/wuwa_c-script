using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200128F RID: 4751
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPSCPool")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FWorldPSCPool : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601168F RID: 71311 RVA: 0x00198E8A File Offset: 0x0019708A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPSCPool._ScriptStructPtr != 0) ? FWorldPSCPool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPSCPool", ref FWorldPSCPool._ScriptStructPtr);
		}

		// Token: 0x170043CC RID: 17356
		// (get) Token: 0x06011690 RID: 71312 RVA: 0x00198EB0 File Offset: 0x001970B0
		// (set) Token: 0x06011691 RID: 71313 RVA: 0x00198EF3 File Offset: 0x001970F3
		public TMap<UParticleSystem, FPSCPool> WorldParticleSystemPools
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UParticleSystem, FPSCPool> result;
				if ((result = this._WorldParticleSystemPools) == null)
				{
					result = (this._WorldParticleSystemPools = new TMap<UParticleSystem, FPSCPool>(base.NativePtr + (IntPtr)FWorldPSCPool.__PropertyOffset_WorldParticleSystemPools, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.WorldParticleSystemPools.CopyAssign(value);
			}
		}

		// Token: 0x06011692 RID: 71314 RVA: 0x00198F01 File Offset: 0x00197101
		public FWorldPSCPool()
		{
		}

		// Token: 0x06011693 RID: 71315 RVA: 0x00198F09 File Offset: 0x00197109
		public FWorldPSCPool(TMap<UParticleSystem, FPSCPool> WorldParticleSystemPools)
		{
			this.WorldParticleSystemPools = WorldParticleSystemPools;
		}

		// Token: 0x06011694 RID: 71316 RVA: 0x00198F18 File Offset: 0x00197118
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPSCPool.StaticStruct();
		}

		// Token: 0x06011695 RID: 71317 RVA: 0x00198F24 File Offset: 0x00197124
		[NullableContext(2)]
		public FWorldPSCPool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011696 RID: 71318 RVA: 0x00198F2E File Offset: 0x0019712E
		public FWorldPSCPool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011697 RID: 71319 RVA: 0x00198F39 File Offset: 0x00197139
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPSCPool(Pointer, false, true);
		}

		// Token: 0x06011698 RID: 71320 RVA: 0x00198F43 File Offset: 0x00197143
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPSCPool(Pointer, MemoryOwner);
		}

		// Token: 0x04009508 RID: 38152
		public const string __ObjectPath = "/Script/Engine.WorldPSCPool";

		// Token: 0x04009509 RID: 38153
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400950A RID: 38154
		internal static int __PropertyOffset_WorldParticleSystemPools;

		// Token: 0x0400950B RID: 38155
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UParticleSystem, FPSCPool> _WorldParticleSystemPools;
	}
}
