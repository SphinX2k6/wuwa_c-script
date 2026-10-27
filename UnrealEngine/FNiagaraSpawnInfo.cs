using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025EC RID: 9708
	[UnrealObjectPath("/Script/Niagara.NiagaraSpawnInfo")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNiagaraSpawnInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602413F RID: 147775 RVA: 0x003561AD File Offset: 0x003543AD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraSpawnInfo._ScriptStructPtr != 0) ? FNiagaraSpawnInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraSpawnInfo", ref FNiagaraSpawnInfo._ScriptStructPtr);
		}

		// Token: 0x17008ACF RID: 35535
		// (get) Token: 0x06024140 RID: 147776 RVA: 0x003561D1 File Offset: 0x003543D1
		// (set) Token: 0x06024141 RID: 147777 RVA: 0x003561E1 File Offset: 0x003543E1
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraSpawnInfo.__PropertyOffset_Count);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraSpawnInfo.__PropertyOffset_Count) = value;
			}
		}

		// Token: 0x17008AD0 RID: 35536
		// (get) Token: 0x06024142 RID: 147778 RVA: 0x003561F2 File Offset: 0x003543F2
		// (set) Token: 0x06024143 RID: 147779 RVA: 0x00356202 File Offset: 0x00354402
		public unsafe float InterpStartDt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraSpawnInfo.__PropertyOffset_InterpStartDt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraSpawnInfo.__PropertyOffset_InterpStartDt) = value;
			}
		}

		// Token: 0x17008AD1 RID: 35537
		// (get) Token: 0x06024144 RID: 147780 RVA: 0x00356213 File Offset: 0x00354413
		// (set) Token: 0x06024145 RID: 147781 RVA: 0x00356223 File Offset: 0x00354423
		public unsafe float IntervalDt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraSpawnInfo.__PropertyOffset_IntervalDt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraSpawnInfo.__PropertyOffset_IntervalDt) = value;
			}
		}

		// Token: 0x17008AD2 RID: 35538
		// (get) Token: 0x06024146 RID: 147782 RVA: 0x00356234 File Offset: 0x00354434
		// (set) Token: 0x06024147 RID: 147783 RVA: 0x00356244 File Offset: 0x00354444
		public unsafe int SpawnGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraSpawnInfo.__PropertyOffset_SpawnGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraSpawnInfo.__PropertyOffset_SpawnGroup) = value;
			}
		}

		// Token: 0x06024148 RID: 147784 RVA: 0x00356255 File Offset: 0x00354455
		public FNiagaraSpawnInfo()
		{
		}

		// Token: 0x06024149 RID: 147785 RVA: 0x0035625D File Offset: 0x0035445D
		public FNiagaraSpawnInfo(int Count, float InterpStartDt, float IntervalDt, int SpawnGroup)
		{
			this.Count = Count;
			this.InterpStartDt = InterpStartDt;
			this.IntervalDt = IntervalDt;
			this.SpawnGroup = SpawnGroup;
		}

		// Token: 0x0602414A RID: 147786 RVA: 0x00356282 File Offset: 0x00354482
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraSpawnInfo.StaticStruct();
		}

		// Token: 0x0602414B RID: 147787 RVA: 0x0035628E File Offset: 0x0035448E
		[NullableContext(2)]
		public FNiagaraSpawnInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602414C RID: 147788 RVA: 0x00356298 File Offset: 0x00354498
		public FNiagaraSpawnInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602414D RID: 147789 RVA: 0x003562A3 File Offset: 0x003544A3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraSpawnInfo(Pointer, false, true);
		}

		// Token: 0x0602414E RID: 147790 RVA: 0x003562AD File Offset: 0x003544AD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraSpawnInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0401359B RID: 79259
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraSpawnInfo";

		// Token: 0x0401359C RID: 79260
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401359D RID: 79261
		internal static int __PropertyOffset_Count;

		// Token: 0x0401359E RID: 79262
		internal static int __PropertyOffset_InterpStartDt;

		// Token: 0x0401359F RID: 79263
		internal static int __PropertyOffset_IntervalDt;

		// Token: 0x040135A0 RID: 79264
		internal static int __PropertyOffset_SpawnGroup;
	}
}
