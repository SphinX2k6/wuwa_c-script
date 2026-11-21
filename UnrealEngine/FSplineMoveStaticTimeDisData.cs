using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000353 RID: 851
	[UnrealObjectPath("/Script/KuroComponent.SplineMoveStaticTimeDisData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSplineMoveStaticTimeDisData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060056F1 RID: 22257 RVA: 0x0007A940 File Offset: 0x00078B40
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSplineMoveStaticTimeDisData._ScriptStructPtr != 0) ? FSplineMoveStaticTimeDisData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComponent.SplineMoveStaticTimeDisData", ref FSplineMoveStaticTimeDisData._ScriptStructPtr);
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x060056F2 RID: 22258 RVA: 0x0007A964 File Offset: 0x00078B64
		// (set) Token: 0x060056F3 RID: 22259 RVA: 0x0007A978 File Offset: 0x00078B78
		[Nullable(2)]
		public unsafe UCurveFloat TimeDisCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FSplineMoveStaticTimeDisData.__PropertyOffset_TimeDisCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSplineMoveStaticTimeDisData.__PropertyOffset_TimeDisCurve, value);
			}
		}

		// Token: 0x060056F4 RID: 22260 RVA: 0x0007A98D File Offset: 0x00078B8D
		public FSplineMoveStaticTimeDisData()
		{
		}

		// Token: 0x060056F5 RID: 22261 RVA: 0x0007A995 File Offset: 0x00078B95
		protected override IntPtr GetUStructPtr()
		{
			return FSplineMoveStaticTimeDisData.StaticStruct();
		}

		// Token: 0x060056F6 RID: 22262 RVA: 0x0007A9A1 File Offset: 0x00078BA1
		[NullableContext(2)]
		public FSplineMoveStaticTimeDisData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060056F7 RID: 22263 RVA: 0x0007A9AB File Offset: 0x00078BAB
		public FSplineMoveStaticTimeDisData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060056F8 RID: 22264 RVA: 0x0007A9B6 File Offset: 0x00078BB6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSplineMoveStaticTimeDisData(Pointer, false, true);
		}

		// Token: 0x060056F9 RID: 22265 RVA: 0x0007A9C0 File Offset: 0x00078BC0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSplineMoveStaticTimeDisData(Pointer, MemoryOwner);
		}

		// Token: 0x040023C8 RID: 9160
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComponent.SplineMoveStaticTimeDisData";

		// Token: 0x040023C9 RID: 9161
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040023CA RID: 9162
		internal static int __PropertyOffset_TimeDisCurve;
	}
}
