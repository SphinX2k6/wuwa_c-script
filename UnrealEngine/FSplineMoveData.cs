using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200176C RID: 5996
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComponent.SplineMoveData")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FSplineMoveData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060158FF RID: 88319 RVA: 0x001FB983 File Offset: 0x001F9B83
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSplineMoveData._ScriptStructPtr != 0) ? FSplineMoveData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComponent.SplineMoveData", ref FSplineMoveData._ScriptStructPtr);
		}

		// Token: 0x17005517 RID: 21783
		// (get) Token: 0x06015900 RID: 88320 RVA: 0x001FB9A7 File Offset: 0x001F9BA7
		// (set) Token: 0x06015901 RID: 88321 RVA: 0x001FB9BB File Offset: 0x001F9BBB
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

		// Token: 0x17005518 RID: 21784
		// (get) Token: 0x06015902 RID: 88322 RVA: 0x001FB9D0 File Offset: 0x001F9BD0
		// (set) Token: 0x06015903 RID: 88323 RVA: 0x001FBA13 File Offset: 0x001F9C13
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

		// Token: 0x17005519 RID: 21785
		// (get) Token: 0x06015904 RID: 88324 RVA: 0x001FBA34 File Offset: 0x001F9C34
		// (set) Token: 0x06015905 RID: 88325 RVA: 0x001FBA48 File Offset: 0x001F9C48
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

		// Token: 0x06015906 RID: 88326 RVA: 0x001FBA5D File Offset: 0x001F9C5D
		public FSplineMoveData()
		{
		}

		// Token: 0x06015907 RID: 88327 RVA: 0x001FBA65 File Offset: 0x001F9C65
		public FSplineMoveData(USplineComponent Spline, FSplineMoveStaticTimeDisData StaticTimeDisData, FSplineMoveDynamicSpeedData DynamicSpeedData)
		{
			this.Spline = Spline;
			this.StaticTimeDisData = StaticTimeDisData;
			this.DynamicSpeedData = DynamicSpeedData;
		}

		// Token: 0x06015908 RID: 88328 RVA: 0x001FBA82 File Offset: 0x001F9C82
		protected override IntPtr GetUStructPtr()
		{
			return FSplineMoveData.StaticStruct();
		}

		// Token: 0x06015909 RID: 88329 RVA: 0x001FBA8E File Offset: 0x001F9C8E
		[NullableContext(2)]
		public FSplineMoveData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601590A RID: 88330 RVA: 0x001FBA98 File Offset: 0x001F9C98
		public FSplineMoveData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601590B RID: 88331 RVA: 0x001FBAA3 File Offset: 0x001F9CA3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSplineMoveData(Pointer, false, true);
		}

		// Token: 0x0601590C RID: 88332 RVA: 0x001FBAAD File Offset: 0x001F9CAD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSplineMoveData(Pointer, MemoryOwner);
		}

		// Token: 0x0400BC3F RID: 48191
		public const string __ObjectPath = "/Script/KuroComponent.SplineMoveData";

		// Token: 0x0400BC40 RID: 48192
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BC41 RID: 48193
		internal static int __PropertyOffset_Spline;

		// Token: 0x0400BC42 RID: 48194
		internal static int __PropertyOffset_StaticTimeDisData;

		// Token: 0x0400BC43 RID: 48195
		[Nullable(2)]
		private FSplineMoveStaticTimeDisData _StaticTimeDisData;

		// Token: 0x0400BC44 RID: 48196
		internal static int __PropertyOffset_DynamicSpeedData;
	}
}
