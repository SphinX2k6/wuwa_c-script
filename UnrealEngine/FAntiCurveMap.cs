using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200084C RID: 2124
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AntiCurveMap")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAntiCurveMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007285 RID: 29317 RVA: 0x000A3F9C File Offset: 0x000A219C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAntiCurveMap._ScriptStructPtr != 0) ? FAntiCurveMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AntiCurveMap", ref FAntiCurveMap._ScriptStructPtr);
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x06007286 RID: 29318 RVA: 0x000A3FC0 File Offset: 0x000A21C0
		// (set) Token: 0x06007287 RID: 29319 RVA: 0x000A3FD4 File Offset: 0x000A21D4
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAntiCurveMap.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAntiCurveMap.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x06007288 RID: 29320 RVA: 0x000A3FE9 File Offset: 0x000A21E9
		// (set) Token: 0x06007289 RID: 29321 RVA: 0x000A3FF9 File Offset: 0x000A21F9
		public unsafe float AntiThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAntiCurveMap.__PropertyOffset_AntiThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAntiCurveMap.__PropertyOffset_AntiThreshold) = value;
			}
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x0600728A RID: 29322 RVA: 0x000A400C File Offset: 0x000A220C
		// (set) Token: 0x0600728B RID: 29323 RVA: 0x000A404F File Offset: 0x000A224F
		public TArray<FName> AntiCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._AntiCurves) == null)
				{
					result = (this._AntiCurves = new TArray<FName>(base.NativePtr + (IntPtr)FAntiCurveMap.__PropertyOffset_AntiCurves, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AntiCurves.CopyAssign(value);
			}
		}

		// Token: 0x0600728C RID: 29324 RVA: 0x000A405D File Offset: 0x000A225D
		public FAntiCurveMap()
		{
		}

		// Token: 0x0600728D RID: 29325 RVA: 0x000A4065 File Offset: 0x000A2265
		public FAntiCurveMap(FName Name, float AntiThreshold, TArray<FName> AntiCurves)
		{
			this.Name = Name;
			this.AntiThreshold = AntiThreshold;
			this.AntiCurves = AntiCurves;
		}

		// Token: 0x0600728E RID: 29326 RVA: 0x000A4082 File Offset: 0x000A2282
		protected override IntPtr GetUStructPtr()
		{
			return FAntiCurveMap.StaticStruct();
		}

		// Token: 0x0600728F RID: 29327 RVA: 0x000A408E File Offset: 0x000A228E
		[NullableContext(2)]
		public FAntiCurveMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007290 RID: 29328 RVA: 0x000A4098 File Offset: 0x000A2298
		public FAntiCurveMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007291 RID: 29329 RVA: 0x000A40A3 File Offset: 0x000A22A3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAntiCurveMap(Pointer, false, true);
		}

		// Token: 0x06007292 RID: 29330 RVA: 0x000A40AD File Offset: 0x000A22AD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAntiCurveMap(Pointer, MemoryOwner);
		}

		// Token: 0x04003701 RID: 14081
		public const string __ObjectPath = "/Script/Engine.AntiCurveMap";

		// Token: 0x04003702 RID: 14082
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003703 RID: 14083
		internal static int __PropertyOffset_Name;

		// Token: 0x04003704 RID: 14084
		internal static int __PropertyOffset_AntiThreshold;

		// Token: 0x04003705 RID: 14085
		internal static int __PropertyOffset_AntiCurves;

		// Token: 0x04003706 RID: 14086
		[Nullable(2)]
		private TArray<FName> _AntiCurves;
	}
}
