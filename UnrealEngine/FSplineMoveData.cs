using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000351 RID: 849
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComponent.SplineMoveData")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FSplineMoveData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060056DD RID: 22237 RVA: 0x0007A74B File Offset: 0x0007894B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSplineMoveData._ScriptStructPtr != 0) ? FSplineMoveData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComponent.SplineMoveData", ref FSplineMoveData._ScriptStructPtr);
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x060056DE RID: 22238 RVA: 0x0007A76F File Offset: 0x0007896F
		// (set) Token: 0x060056DF RID: 22239 RVA: 0x0007A783 File Offset: 0x00078983
		[Nullable(2)]
		public unsafe USplineComponent Spline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FSplineMoveData.__PropertyOffset_Spline);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSplineMoveData.__PropertyOffset_Spline, value);
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x060056E0 RID: 22240 RVA: 0x0007A798 File Offset: 0x00078998
		// (set) Token: 0x060056E1 RID: 22241 RVA: 0x0007A7DB File Offset: 0x000789DB
		public FSplineMoveStaticTimeDisData StaticTimeDisData
		{
			get
			{
				base.FastCheckIsValid();
				FSplineMoveStaticTimeDisData result;
				if ((result = this._StaticTimeDisData) == null)
				{
					result = (this._StaticTimeDisData = new FSplineMoveStaticTimeDisData(base.NativePtr + (IntPtr)FSplineMoveData.__PropertyOffset_StaticTimeDisData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSplineMoveStaticTimeDisData.StaticStruct(), base.NativePtr + (IntPtr)FSplineMoveData.__PropertyOffset_StaticTimeDisData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x060056E2 RID: 22242 RVA: 0x0007A7FC File Offset: 0x000789FC
		// (set) Token: 0x060056E3 RID: 22243 RVA: 0x0007A810 File Offset: 0x00078A10
		public unsafe FSplineMoveDynamicSpeedData DynamicSpeedData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineMoveData.__PropertyOffset_DynamicSpeedData);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineMoveData.__PropertyOffset_DynamicSpeedData) = value;
			}
		}

		// Token: 0x060056E4 RID: 22244 RVA: 0x0007A825 File Offset: 0x00078A25
		public FSplineMoveData()
		{
		}

		// Token: 0x060056E5 RID: 22245 RVA: 0x0007A82D File Offset: 0x00078A2D
		protected override IntPtr GetUStructPtr()
		{
			return FSplineMoveData.StaticStruct();
		}

		// Token: 0x060056E6 RID: 22246 RVA: 0x0007A839 File Offset: 0x00078A39
		[NullableContext(2)]
		public FSplineMoveData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060056E7 RID: 22247 RVA: 0x0007A843 File Offset: 0x00078A43
		public FSplineMoveData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060056E8 RID: 22248 RVA: 0x0007A84E File Offset: 0x00078A4E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSplineMoveData(Pointer, false, true);
		}

		// Token: 0x060056E9 RID: 22249 RVA: 0x0007A858 File Offset: 0x00078A58
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSplineMoveData(Pointer, MemoryOwner);
		}

		// Token: 0x040023BC RID: 9148
		public const string __ObjectPath = "/Script/KuroComponent.SplineMoveData";

		// Token: 0x040023BD RID: 9149
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040023BE RID: 9150
		internal static int __PropertyOffset_Spline;

		// Token: 0x040023BF RID: 9151
		internal static int __PropertyOffset_StaticTimeDisData;

		// Token: 0x040023C0 RID: 9152
		[Nullable(2)]
		private FSplineMoveStaticTimeDisData _StaticTimeDisData;

		// Token: 0x040023C1 RID: 9153
		internal static int __PropertyOffset_DynamicSpeedData;
	}
}
