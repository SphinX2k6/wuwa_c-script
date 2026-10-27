using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001042 RID: 4162
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PSCPool")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FPSCPool : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ECDA RID: 60634 RVA: 0x0015F537 File Offset: 0x0015D737
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSCPool._ScriptStructPtr != 0) ? FPSCPool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSCPool", ref FPSCPool._ScriptStructPtr);
		}

		// Token: 0x1700395D RID: 14685
		// (get) Token: 0x0600ECDB RID: 60635 RVA: 0x0015F55C File Offset: 0x0015D75C
		// (set) Token: 0x0600ECDC RID: 60636 RVA: 0x0015F59F File Offset: 0x0015D79F
		public TArray<FPSCPoolElem> FreeElements
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPSCPoolElem> result;
				if ((result = this._FreeElements) == null)
				{
					result = (this._FreeElements = new TArray<FPSCPoolElem>(base.NativePtr + (IntPtr)FPSCPool.__PropertyOffset_FreeElements, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FreeElements.CopyAssign(value);
			}
		}

		// Token: 0x1700395E RID: 14686
		// (get) Token: 0x0600ECDD RID: 60637 RVA: 0x0015F5B0 File Offset: 0x0015D7B0
		// (set) Token: 0x0600ECDE RID: 60638 RVA: 0x0015F5F3 File Offset: 0x0015D7F3
		public TArray<UParticleSystemComponent> InUseComponents_Auto
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UParticleSystemComponent> result;
				if ((result = this._InUseComponents_Auto) == null)
				{
					result = (this._InUseComponents_Auto = new TArray<UParticleSystemComponent>(base.NativePtr + (IntPtr)FPSCPool.__PropertyOffset_InUseComponents_Auto, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InUseComponents_Auto.CopyAssign(value);
			}
		}

		// Token: 0x1700395F RID: 14687
		// (get) Token: 0x0600ECDF RID: 60639 RVA: 0x0015F604 File Offset: 0x0015D804
		// (set) Token: 0x0600ECE0 RID: 60640 RVA: 0x0015F647 File Offset: 0x0015D847
		public TArray<UParticleSystemComponent> InUseComponents_Manual
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UParticleSystemComponent> result;
				if ((result = this._InUseComponents_Manual) == null)
				{
					result = (this._InUseComponents_Manual = new TArray<UParticleSystemComponent>(base.NativePtr + (IntPtr)FPSCPool.__PropertyOffset_InUseComponents_Manual, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InUseComponents_Manual.CopyAssign(value);
			}
		}

		// Token: 0x0600ECE1 RID: 60641 RVA: 0x0015F655 File Offset: 0x0015D855
		public FPSCPool()
		{
		}

		// Token: 0x0600ECE2 RID: 60642 RVA: 0x0015F65D File Offset: 0x0015D85D
		public FPSCPool(TArray<FPSCPoolElem> FreeElements, TArray<UParticleSystemComponent> InUseComponents_Auto, TArray<UParticleSystemComponent> InUseComponents_Manual)
		{
			this.FreeElements = FreeElements;
			this.InUseComponents_Auto = InUseComponents_Auto;
			this.InUseComponents_Manual = InUseComponents_Manual;
		}

		// Token: 0x0600ECE3 RID: 60643 RVA: 0x0015F67A File Offset: 0x0015D87A
		protected override IntPtr GetUStructPtr()
		{
			return FPSCPool.StaticStruct();
		}

		// Token: 0x0600ECE4 RID: 60644 RVA: 0x0015F686 File Offset: 0x0015D886
		[NullableContext(2)]
		public FPSCPool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ECE5 RID: 60645 RVA: 0x0015F690 File Offset: 0x0015D890
		public FPSCPool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ECE6 RID: 60646 RVA: 0x0015F69B File Offset: 0x0015D89B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSCPool(Pointer, false, true);
		}

		// Token: 0x0600ECE7 RID: 60647 RVA: 0x0015F6A5 File Offset: 0x0015D8A5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSCPool(Pointer, MemoryOwner);
		}

		// Token: 0x0400803D RID: 32829
		public const string __ObjectPath = "/Script/Engine.PSCPool";

		// Token: 0x0400803E RID: 32830
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400803F RID: 32831
		internal static int __PropertyOffset_FreeElements;

		// Token: 0x04008040 RID: 32832
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPSCPoolElem> _FreeElements;

		// Token: 0x04008041 RID: 32833
		internal static int __PropertyOffset_InUseComponents_Auto;

		// Token: 0x04008042 RID: 32834
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UParticleSystemComponent> _InUseComponents_Auto;

		// Token: 0x04008043 RID: 32835
		internal static int __PropertyOffset_InUseComponents_Manual;

		// Token: 0x04008044 RID: 32836
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UParticleSystemComponent> _InUseComponents_Manual;
	}
}
