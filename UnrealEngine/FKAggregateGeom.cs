using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CC4 RID: 3268
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KAggregateGeom")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FKAggregateGeom : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A521 RID: 42273 RVA: 0x000EADA1 File Offset: 0x000E8FA1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKAggregateGeom._ScriptStructPtr != 0) ? FKAggregateGeom._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KAggregateGeom", ref FKAggregateGeom._ScriptStructPtr);
		}

		// Token: 0x17002744 RID: 10052
		// (get) Token: 0x0600A522 RID: 42274 RVA: 0x000EADC8 File Offset: 0x000E8FC8
		// (set) Token: 0x0600A523 RID: 42275 RVA: 0x000EAE0B File Offset: 0x000E900B
		public TArray<FKSphereElem> SphereElems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSphereElem> result;
				if ((result = this._SphereElems) == null)
				{
					result = (this._SphereElems = new TArray<FKSphereElem>(base.NativePtr + (IntPtr)FKAggregateGeom.__PropertyOffset_SphereElems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SphereElems.CopyAssign(value);
			}
		}

		// Token: 0x17002745 RID: 10053
		// (get) Token: 0x0600A524 RID: 42276 RVA: 0x000EAE1C File Offset: 0x000E901C
		// (set) Token: 0x0600A525 RID: 42277 RVA: 0x000EAE5F File Offset: 0x000E905F
		public TArray<FKBoxElem> BoxElems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKBoxElem> result;
				if ((result = this._BoxElems) == null)
				{
					result = (this._BoxElems = new TArray<FKBoxElem>(base.NativePtr + (IntPtr)FKAggregateGeom.__PropertyOffset_BoxElems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoxElems.CopyAssign(value);
			}
		}

		// Token: 0x17002746 RID: 10054
		// (get) Token: 0x0600A526 RID: 42278 RVA: 0x000EAE70 File Offset: 0x000E9070
		// (set) Token: 0x0600A527 RID: 42279 RVA: 0x000EAEB3 File Offset: 0x000E90B3
		public TArray<FKSphylElem> SphylElems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSphylElem> result;
				if ((result = this._SphylElems) == null)
				{
					result = (this._SphylElems = new TArray<FKSphylElem>(base.NativePtr + (IntPtr)FKAggregateGeom.__PropertyOffset_SphylElems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SphylElems.CopyAssign(value);
			}
		}

		// Token: 0x17002747 RID: 10055
		// (get) Token: 0x0600A528 RID: 42280 RVA: 0x000EAEC4 File Offset: 0x000E90C4
		// (set) Token: 0x0600A529 RID: 42281 RVA: 0x000EAF07 File Offset: 0x000E9107
		public TArray<FKConvexElem> ConvexElems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKConvexElem> result;
				if ((result = this._ConvexElems) == null)
				{
					result = (this._ConvexElems = new TArray<FKConvexElem>(base.NativePtr + (IntPtr)FKAggregateGeom.__PropertyOffset_ConvexElems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ConvexElems.CopyAssign(value);
			}
		}

		// Token: 0x17002748 RID: 10056
		// (get) Token: 0x0600A52A RID: 42282 RVA: 0x000EAF18 File Offset: 0x000E9118
		// (set) Token: 0x0600A52B RID: 42283 RVA: 0x000EAF5B File Offset: 0x000E915B
		public TArray<FKTaperedCapsuleElem> TaperedCapsuleElems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKTaperedCapsuleElem> result;
				if ((result = this._TaperedCapsuleElems) == null)
				{
					result = (this._TaperedCapsuleElems = new TArray<FKTaperedCapsuleElem>(base.NativePtr + (IntPtr)FKAggregateGeom.__PropertyOffset_TaperedCapsuleElems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TaperedCapsuleElems.CopyAssign(value);
			}
		}

		// Token: 0x0600A52C RID: 42284 RVA: 0x000EAF69 File Offset: 0x000E9169
		public FKAggregateGeom()
		{
		}

		// Token: 0x0600A52D RID: 42285 RVA: 0x000EAF71 File Offset: 0x000E9171
		public FKAggregateGeom(TArray<FKSphereElem> SphereElems, TArray<FKBoxElem> BoxElems, TArray<FKSphylElem> SphylElems, TArray<FKConvexElem> ConvexElems, TArray<FKTaperedCapsuleElem> TaperedCapsuleElems)
		{
			this.SphereElems = SphereElems;
			this.BoxElems = BoxElems;
			this.SphylElems = SphylElems;
			this.ConvexElems = ConvexElems;
			this.TaperedCapsuleElems = TaperedCapsuleElems;
		}

		// Token: 0x0600A52E RID: 42286 RVA: 0x000EAF9E File Offset: 0x000E919E
		protected override IntPtr GetUStructPtr()
		{
			return FKAggregateGeom.StaticStruct();
		}

		// Token: 0x0600A52F RID: 42287 RVA: 0x000EAFAA File Offset: 0x000E91AA
		[NullableContext(2)]
		public FKAggregateGeom(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A530 RID: 42288 RVA: 0x000EAFB4 File Offset: 0x000E91B4
		public FKAggregateGeom(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A531 RID: 42289 RVA: 0x000EAFBF File Offset: 0x000E91BF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKAggregateGeom(Pointer, false, true);
		}

		// Token: 0x0600A532 RID: 42290 RVA: 0x000EAFC9 File Offset: 0x000E91C9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKAggregateGeom(Pointer, MemoryOwner);
		}

		// Token: 0x04005AD5 RID: 23253
		public const string __ObjectPath = "/Script/Engine.KAggregateGeom";

		// Token: 0x04005AD6 RID: 23254
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005AD7 RID: 23255
		internal static int __PropertyOffset_SphereElems;

		// Token: 0x04005AD8 RID: 23256
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSphereElem> _SphereElems;

		// Token: 0x04005AD9 RID: 23257
		internal static int __PropertyOffset_BoxElems;

		// Token: 0x04005ADA RID: 23258
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKBoxElem> _BoxElems;

		// Token: 0x04005ADB RID: 23259
		internal static int __PropertyOffset_SphylElems;

		// Token: 0x04005ADC RID: 23260
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSphylElem> _SphylElems;

		// Token: 0x04005ADD RID: 23261
		internal static int __PropertyOffset_ConvexElems;

		// Token: 0x04005ADE RID: 23262
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKConvexElem> _ConvexElems;

		// Token: 0x04005ADF RID: 23263
		internal static int __PropertyOffset_TaperedCapsuleElems;

		// Token: 0x04005AE0 RID: 23264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKTaperedCapsuleElem> _TaperedCapsuleElems;
	}
}
