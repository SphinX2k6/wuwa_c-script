using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200176E RID: 5998
	[UnrealObjectPath("/Script/KuroComponent.SplineMoveStaticTimeDisData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSplineMoveStaticTimeDisData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015914 RID: 88340 RVA: 0x001FBB94 File Offset: 0x001F9D94
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSplineMoveStaticTimeDisData._ScriptStructPtr != 0) ? FSplineMoveStaticTimeDisData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComponent.SplineMoveStaticTimeDisData", ref FSplineMoveStaticTimeDisData._ScriptStructPtr);
		}

		// Token: 0x1700551A RID: 21786
		// (get) Token: 0x06015915 RID: 88341 RVA: 0x001FBBB8 File Offset: 0x001F9DB8
		// (set) Token: 0x06015916 RID: 88342 RVA: 0x001FBBCC File Offset: 0x001F9DCC
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

		// Token: 0x06015917 RID: 88343 RVA: 0x001FBBE1 File Offset: 0x001F9DE1
		public FSplineMoveStaticTimeDisData()
		{
		}

		// Token: 0x06015918 RID: 88344 RVA: 0x001FBBE9 File Offset: 0x001F9DE9
		[NullableContext(1)]
		public FSplineMoveStaticTimeDisData(UCurveFloat TimeDisCurve)
		{
			this.TimeDisCurve = TimeDisCurve;
		}

		// Token: 0x06015919 RID: 88345 RVA: 0x001FBBF8 File Offset: 0x001F9DF8
		protected override IntPtr GetUStructPtr()
		{
			return FSplineMoveStaticTimeDisData.StaticStruct();
		}

		// Token: 0x0601591A RID: 88346 RVA: 0x001FBC04 File Offset: 0x001F9E04
		[NullableContext(2)]
		public FSplineMoveStaticTimeDisData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601591B RID: 88347 RVA: 0x001FBC0E File Offset: 0x001F9E0E
		public FSplineMoveStaticTimeDisData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601591C RID: 88348 RVA: 0x001FBC19 File Offset: 0x001F9E19
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSplineMoveStaticTimeDisData(Pointer, false, true);
		}

		// Token: 0x0601591D RID: 88349 RVA: 0x001FBC23 File Offset: 0x001F9E23
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSplineMoveStaticTimeDisData(Pointer, MemoryOwner);
		}

		// Token: 0x0400BC4B RID: 48203
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComponent.SplineMoveStaticTimeDisData";

		// Token: 0x0400BC4C RID: 48204
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BC4D RID: 48205
		internal static int __PropertyOffset_TimeDisCurve;
	}
}
