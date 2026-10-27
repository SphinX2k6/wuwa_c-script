using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002596 RID: 9622
	[UnrealObjectPath("/Script/Niagara.NiagaraDetailsLevelScaleOverrides")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FNiagaraDetailsLevelScaleOverrides : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023B8E RID: 146318 RVA: 0x0034D1B1 File Offset: 0x0034B3B1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDetailsLevelScaleOverrides._ScriptStructPtr != 0) ? FNiagaraDetailsLevelScaleOverrides._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraDetailsLevelScaleOverrides", ref FNiagaraDetailsLevelScaleOverrides._ScriptStructPtr);
		}

		// Token: 0x17008937 RID: 35127
		// (get) Token: 0x06023B8F RID: 146319 RVA: 0x0034D1D5 File Offset: 0x0034B3D5
		// (set) Token: 0x06023B90 RID: 146320 RVA: 0x0034D1E5 File Offset: 0x0034B3E5
		public unsafe float Low
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDetailsLevelScaleOverrides.__PropertyOffset_Low);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDetailsLevelScaleOverrides.__PropertyOffset_Low) = value;
			}
		}

		// Token: 0x17008938 RID: 35128
		// (get) Token: 0x06023B91 RID: 146321 RVA: 0x0034D1F6 File Offset: 0x0034B3F6
		// (set) Token: 0x06023B92 RID: 146322 RVA: 0x0034D206 File Offset: 0x0034B406
		public unsafe float Medium
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDetailsLevelScaleOverrides.__PropertyOffset_Medium);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDetailsLevelScaleOverrides.__PropertyOffset_Medium) = value;
			}
		}

		// Token: 0x17008939 RID: 35129
		// (get) Token: 0x06023B93 RID: 146323 RVA: 0x0034D217 File Offset: 0x0034B417
		// (set) Token: 0x06023B94 RID: 146324 RVA: 0x0034D227 File Offset: 0x0034B427
		public unsafe float High
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDetailsLevelScaleOverrides.__PropertyOffset_High);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDetailsLevelScaleOverrides.__PropertyOffset_High) = value;
			}
		}

		// Token: 0x1700893A RID: 35130
		// (get) Token: 0x06023B95 RID: 146325 RVA: 0x0034D238 File Offset: 0x0034B438
		// (set) Token: 0x06023B96 RID: 146326 RVA: 0x0034D248 File Offset: 0x0034B448
		public unsafe float Epic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDetailsLevelScaleOverrides.__PropertyOffset_Epic);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDetailsLevelScaleOverrides.__PropertyOffset_Epic) = value;
			}
		}

		// Token: 0x1700893B RID: 35131
		// (get) Token: 0x06023B97 RID: 146327 RVA: 0x0034D259 File Offset: 0x0034B459
		// (set) Token: 0x06023B98 RID: 146328 RVA: 0x0034D269 File Offset: 0x0034B469
		public unsafe float Cine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDetailsLevelScaleOverrides.__PropertyOffset_Cine);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDetailsLevelScaleOverrides.__PropertyOffset_Cine) = value;
			}
		}

		// Token: 0x06023B99 RID: 146329 RVA: 0x0034D27A File Offset: 0x0034B47A
		public FNiagaraDetailsLevelScaleOverrides()
		{
		}

		// Token: 0x06023B9A RID: 146330 RVA: 0x0034D282 File Offset: 0x0034B482
		public FNiagaraDetailsLevelScaleOverrides(float Low, float Medium, float High, float Epic, float Cine)
		{
			this.Low = Low;
			this.Medium = Medium;
			this.High = High;
			this.Epic = Epic;
			this.Cine = Cine;
		}

		// Token: 0x06023B9B RID: 146331 RVA: 0x0034D2AF File Offset: 0x0034B4AF
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDetailsLevelScaleOverrides.StaticStruct();
		}

		// Token: 0x06023B9C RID: 146332 RVA: 0x0034D2BB File Offset: 0x0034B4BB
		[NullableContext(2)]
		public FNiagaraDetailsLevelScaleOverrides(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023B9D RID: 146333 RVA: 0x0034D2C5 File Offset: 0x0034B4C5
		public FNiagaraDetailsLevelScaleOverrides(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023B9E RID: 146334 RVA: 0x0034D2D0 File Offset: 0x0034B4D0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDetailsLevelScaleOverrides(Pointer, false, true);
		}

		// Token: 0x06023B9F RID: 146335 RVA: 0x0034D2DA File Offset: 0x0034B4DA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDetailsLevelScaleOverrides(Pointer, MemoryOwner);
		}

		// Token: 0x0401327D RID: 78461
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraDetailsLevelScaleOverrides";

		// Token: 0x0401327E RID: 78462
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401327F RID: 78463
		internal static int __PropertyOffset_Low;

		// Token: 0x04013280 RID: 78464
		internal static int __PropertyOffset_Medium;

		// Token: 0x04013281 RID: 78465
		internal static int __PropertyOffset_High;

		// Token: 0x04013282 RID: 78466
		internal static int __PropertyOffset_Epic;

		// Token: 0x04013283 RID: 78467
		internal static int __PropertyOffset_Cine;
	}
}
