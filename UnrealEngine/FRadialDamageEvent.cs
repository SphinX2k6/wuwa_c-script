using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001060 RID: 4192
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RadialDamageEvent")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRadialDamageEvent : FDamageEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EE7C RID: 61052 RVA: 0x00161CC0 File Offset: 0x0015FEC0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRadialDamageEvent._ScriptStructPtr != 0) ? FRadialDamageEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RadialDamageEvent", ref FRadialDamageEvent._ScriptStructPtr);
		}

		// Token: 0x170039B9 RID: 14777
		// (get) Token: 0x0600EE7D RID: 61053 RVA: 0x00161CE4 File Offset: 0x0015FEE4
		// (set) Token: 0x0600EE7E RID: 61054 RVA: 0x00161D27 File Offset: 0x0015FF27
		public FRadialDamageParams Params
		{
			get
			{
				base.FastCheckIsValid();
				FRadialDamageParams result;
				if ((result = this._Params) == null)
				{
					result = (this._Params = new FRadialDamageParams(base.NativePtr + (IntPtr)FRadialDamageEvent.__PropertyOffset_Params, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRadialDamageParams.StaticStruct(), base.NativePtr + (IntPtr)FRadialDamageEvent.__PropertyOffset_Params, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170039BA RID: 14778
		// (get) Token: 0x0600EE7F RID: 61055 RVA: 0x00161D48 File Offset: 0x0015FF48
		// (set) Token: 0x0600EE80 RID: 61056 RVA: 0x00161D5C File Offset: 0x0015FF5C
		public unsafe FVector Origin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRadialDamageEvent.__PropertyOffset_Origin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRadialDamageEvent.__PropertyOffset_Origin) = value;
			}
		}

		// Token: 0x170039BB RID: 14779
		// (get) Token: 0x0600EE81 RID: 61057 RVA: 0x00161D74 File Offset: 0x0015FF74
		// (set) Token: 0x0600EE82 RID: 61058 RVA: 0x00161DB7 File Offset: 0x0015FFB7
		public TArray<FHitResult> ComponentHits
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FHitResult> result;
				if ((result = this._ComponentHits) == null)
				{
					result = (this._ComponentHits = new TArray<FHitResult>(base.NativePtr + (IntPtr)FRadialDamageEvent.__PropertyOffset_ComponentHits, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ComponentHits.CopyAssign(value);
			}
		}

		// Token: 0x0600EE83 RID: 61059 RVA: 0x00161DC5 File Offset: 0x0015FFC5
		public FRadialDamageEvent()
		{
		}

		// Token: 0x0600EE84 RID: 61060 RVA: 0x00161DCD File Offset: 0x0015FFCD
		public FRadialDamageEvent(FRadialDamageParams Params, FVector Origin, TArray<FHitResult> ComponentHits, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UDamageType> DamageTypeClass)
		{
			this.Params = Params;
			this.Origin = Origin;
			this.ComponentHits = ComponentHits;
			base.DamageTypeClass = DamageTypeClass;
		}

		// Token: 0x0600EE85 RID: 61061 RVA: 0x00161DF2 File Offset: 0x0015FFF2
		protected override IntPtr GetUStructPtr()
		{
			return FRadialDamageEvent.StaticStruct();
		}

		// Token: 0x0600EE86 RID: 61062 RVA: 0x00161DFE File Offset: 0x0015FFFE
		[NullableContext(2)]
		public FRadialDamageEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EE87 RID: 61063 RVA: 0x00161E08 File Offset: 0x00160008
		public FRadialDamageEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EE88 RID: 61064 RVA: 0x00161E13 File Offset: 0x00160013
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRadialDamageEvent(Pointer, false, true);
		}

		// Token: 0x0600EE89 RID: 61065 RVA: 0x00161E1D File Offset: 0x0016001D
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRadialDamageEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04008116 RID: 33046
		public new const string __ObjectPath = "/Script/Engine.RadialDamageEvent";

		// Token: 0x04008117 RID: 33047
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008118 RID: 33048
		internal static int __PropertyOffset_Params;

		// Token: 0x04008119 RID: 33049
		[Nullable(2)]
		private FRadialDamageParams _Params;

		// Token: 0x0400811A RID: 33050
		internal static int __PropertyOffset_Origin;

		// Token: 0x0400811B RID: 33051
		internal static int __PropertyOffset_ComponentHits;

		// Token: 0x0400811C RID: 33052
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FHitResult> _ComponentHits;
	}
}
