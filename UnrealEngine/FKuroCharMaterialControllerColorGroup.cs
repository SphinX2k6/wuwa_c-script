using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AC0 RID: 6848
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCharMaterialControllerColorGroup")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1632)]
	public class FKuroCharMaterialControllerColorGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019706 RID: 104198 RVA: 0x00259A39 File Offset: 0x00257C39
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCharMaterialControllerColorGroup._ScriptStructPtr != 0) ? FKuroCharMaterialControllerColorGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroCharMaterialControllerColorGroup", ref FKuroCharMaterialControllerColorGroup._ScriptStructPtr);
		}

		// Token: 0x17006575 RID: 25973
		// (get) Token: 0x06019707 RID: 104199 RVA: 0x00259A60 File Offset: 0x00257C60
		// (set) Token: 0x06019708 RID: 104200 RVA: 0x00259AA3 File Offset: 0x00257CA3
		public FKuroCurveLinearColor Start
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._Start) == null)
				{
					result = (this._Start = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroCharMaterialControllerColorGroup.__PropertyOffset_Start, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroCharMaterialControllerColorGroup.__PropertyOffset_Start, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006576 RID: 25974
		// (get) Token: 0x06019709 RID: 104201 RVA: 0x00259AC4 File Offset: 0x00257CC4
		// (set) Token: 0x0601970A RID: 104202 RVA: 0x00259B07 File Offset: 0x00257D07
		public FKuroCurveLinearColor Loop
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._Loop) == null)
				{
					result = (this._Loop = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroCharMaterialControllerColorGroup.__PropertyOffset_Loop, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroCharMaterialControllerColorGroup.__PropertyOffset_Loop, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006577 RID: 25975
		// (get) Token: 0x0601970B RID: 104203 RVA: 0x00259B28 File Offset: 0x00257D28
		// (set) Token: 0x0601970C RID: 104204 RVA: 0x00259B6B File Offset: 0x00257D6B
		public FKuroCurveLinearColor End
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._End) == null)
				{
					result = (this._End = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroCharMaterialControllerColorGroup.__PropertyOffset_End, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroCharMaterialControllerColorGroup.__PropertyOffset_End, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601970D RID: 104205 RVA: 0x00259B8C File Offset: 0x00257D8C
		public FKuroCharMaterialControllerColorGroup()
		{
		}

		// Token: 0x0601970E RID: 104206 RVA: 0x00259B94 File Offset: 0x00257D94
		public FKuroCharMaterialControllerColorGroup(FKuroCurveLinearColor Start, FKuroCurveLinearColor Loop, FKuroCurveLinearColor End)
		{
			this.Start = Start;
			this.Loop = Loop;
			this.End = End;
		}

		// Token: 0x0601970F RID: 104207 RVA: 0x00259BB1 File Offset: 0x00257DB1
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCharMaterialControllerColorGroup.StaticStruct();
		}

		// Token: 0x06019710 RID: 104208 RVA: 0x00259BBD File Offset: 0x00257DBD
		[NullableContext(2)]
		public FKuroCharMaterialControllerColorGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019711 RID: 104209 RVA: 0x00259BC7 File Offset: 0x00257DC7
		public FKuroCharMaterialControllerColorGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019712 RID: 104210 RVA: 0x00259BD2 File Offset: 0x00257DD2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCharMaterialControllerColorGroup(Pointer, false, true);
		}

		// Token: 0x06019713 RID: 104211 RVA: 0x00259BDC File Offset: 0x00257DDC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCharMaterialControllerColorGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400DDA5 RID: 56741
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCharMaterialControllerColorGroup";

		// Token: 0x0400DDA6 RID: 56742
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DDA7 RID: 56743
		internal static int __PropertyOffset_Start;

		// Token: 0x0400DDA8 RID: 56744
		[Nullable(2)]
		private FKuroCurveLinearColor _Start;

		// Token: 0x0400DDA9 RID: 56745
		internal static int __PropertyOffset_Loop;

		// Token: 0x0400DDAA RID: 56746
		[Nullable(2)]
		private FKuroCurveLinearColor _Loop;

		// Token: 0x0400DDAB RID: 56747
		internal static int __PropertyOffset_End;

		// Token: 0x0400DDAC RID: 56748
		[Nullable(2)]
		private FKuroCurveLinearColor _End;
	}
}
