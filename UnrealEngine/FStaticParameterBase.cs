using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200119A RID: 4506
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StaticParameterBase")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FStaticParameterBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601099F RID: 67999 RVA: 0x0018617F File Offset: 0x0018437F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStaticParameterBase._ScriptStructPtr != 0) ? FStaticParameterBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StaticParameterBase", ref FStaticParameterBase._ScriptStructPtr);
		}

		// Token: 0x170040D0 RID: 16592
		// (get) Token: 0x060109A0 RID: 68000 RVA: 0x001861A4 File Offset: 0x001843A4
		// (set) Token: 0x060109A1 RID: 68001 RVA: 0x001861E7 File Offset: 0x001843E7
		public FMaterialParameterInfo ParameterInfo
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialParameterInfo result;
				if ((result = this._ParameterInfo) == null)
				{
					result = (this._ParameterInfo = new FMaterialParameterInfo(base.NativePtr + (IntPtr)FStaticParameterBase.__PropertyOffset_ParameterInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialParameterInfo.StaticStruct(), base.NativePtr + (IntPtr)FStaticParameterBase.__PropertyOffset_ParameterInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170040D1 RID: 16593
		// (get) Token: 0x060109A2 RID: 68002 RVA: 0x00186208 File Offset: 0x00184408
		// (set) Token: 0x060109A3 RID: 68003 RVA: 0x00186218 File Offset: 0x00184418
		public unsafe bool bOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticParameterBase.__PropertyOffset_bOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticParameterBase.__PropertyOffset_bOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040D2 RID: 16594
		// (get) Token: 0x060109A4 RID: 68004 RVA: 0x00186229 File Offset: 0x00184429
		// (set) Token: 0x060109A5 RID: 68005 RVA: 0x0018623D File Offset: 0x0018443D
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticParameterBase.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticParameterBase.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x060109A6 RID: 68006 RVA: 0x00186252 File Offset: 0x00184452
		public FStaticParameterBase()
		{
		}

		// Token: 0x060109A7 RID: 68007 RVA: 0x0018625A File Offset: 0x0018445A
		public FStaticParameterBase(FMaterialParameterInfo ParameterInfo, bool bOverride, FGuid ExpressionGUID)
		{
			this.ParameterInfo = ParameterInfo;
			this.bOverride = bOverride;
			this.ExpressionGUID = ExpressionGUID;
		}

		// Token: 0x060109A8 RID: 68008 RVA: 0x00186277 File Offset: 0x00184477
		protected override IntPtr GetUStructPtr()
		{
			return FStaticParameterBase.StaticStruct();
		}

		// Token: 0x060109A9 RID: 68009 RVA: 0x00186283 File Offset: 0x00184483
		[NullableContext(2)]
		public FStaticParameterBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060109AA RID: 68010 RVA: 0x0018628D File Offset: 0x0018448D
		public FStaticParameterBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060109AB RID: 68011 RVA: 0x00186298 File Offset: 0x00184498
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStaticParameterBase(Pointer, false, true);
		}

		// Token: 0x060109AC RID: 68012 RVA: 0x001862A2 File Offset: 0x001844A2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStaticParameterBase(Pointer, MemoryOwner);
		}

		// Token: 0x04008E16 RID: 36374
		public const string __ObjectPath = "/Script/Engine.StaticParameterBase";

		// Token: 0x04008E17 RID: 36375
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008E18 RID: 36376
		internal static int __PropertyOffset_ParameterInfo;

		// Token: 0x04008E19 RID: 36377
		[Nullable(2)]
		private FMaterialParameterInfo _ParameterInfo;

		// Token: 0x04008E1A RID: 36378
		internal static int __PropertyOffset_bOverride;

		// Token: 0x04008E1B RID: 36379
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
