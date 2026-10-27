using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AC2 RID: 6850
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCharMaterialControllerFloatGroup")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 432)]
	public class FKuroCharMaterialControllerFloatGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019720 RID: 104224 RVA: 0x00259CEA File Offset: 0x00257EEA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCharMaterialControllerFloatGroup._ScriptStructPtr != 0) ? FKuroCharMaterialControllerFloatGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroCharMaterialControllerFloatGroup", ref FKuroCharMaterialControllerFloatGroup._ScriptStructPtr);
		}

		// Token: 0x1700657A RID: 25978
		// (get) Token: 0x06019721 RID: 104225 RVA: 0x00259D10 File Offset: 0x00257F10
		// (set) Token: 0x06019722 RID: 104226 RVA: 0x00259D53 File Offset: 0x00257F53
		public FKuroCurveFloat Start
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Start) == null)
				{
					result = (this._Start = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroCharMaterialControllerFloatGroup.__PropertyOffset_Start, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroCharMaterialControllerFloatGroup.__PropertyOffset_Start, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700657B RID: 25979
		// (get) Token: 0x06019723 RID: 104227 RVA: 0x00259D74 File Offset: 0x00257F74
		// (set) Token: 0x06019724 RID: 104228 RVA: 0x00259DB7 File Offset: 0x00257FB7
		public FKuroCurveFloat Loop
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Loop) == null)
				{
					result = (this._Loop = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroCharMaterialControllerFloatGroup.__PropertyOffset_Loop, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroCharMaterialControllerFloatGroup.__PropertyOffset_Loop, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700657C RID: 25980
		// (get) Token: 0x06019725 RID: 104229 RVA: 0x00259DD8 File Offset: 0x00257FD8
		// (set) Token: 0x06019726 RID: 104230 RVA: 0x00259E1B File Offset: 0x0025801B
		public FKuroCurveFloat End
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._End) == null)
				{
					result = (this._End = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroCharMaterialControllerFloatGroup.__PropertyOffset_End, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroCharMaterialControllerFloatGroup.__PropertyOffset_End, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06019727 RID: 104231 RVA: 0x00259E3C File Offset: 0x0025803C
		public FKuroCharMaterialControllerFloatGroup()
		{
		}

		// Token: 0x06019728 RID: 104232 RVA: 0x00259E44 File Offset: 0x00258044
		public FKuroCharMaterialControllerFloatGroup(FKuroCurveFloat Start, FKuroCurveFloat Loop, FKuroCurveFloat End)
		{
			this.Start = Start;
			this.Loop = Loop;
			this.End = End;
		}

		// Token: 0x06019729 RID: 104233 RVA: 0x00259E61 File Offset: 0x00258061
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCharMaterialControllerFloatGroup.StaticStruct();
		}

		// Token: 0x0601972A RID: 104234 RVA: 0x00259E6D File Offset: 0x0025806D
		[NullableContext(2)]
		public FKuroCharMaterialControllerFloatGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601972B RID: 104235 RVA: 0x00259E77 File Offset: 0x00258077
		public FKuroCharMaterialControllerFloatGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601972C RID: 104236 RVA: 0x00259E82 File Offset: 0x00258082
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCharMaterialControllerFloatGroup(Pointer, false, true);
		}

		// Token: 0x0601972D RID: 104237 RVA: 0x00259E8C File Offset: 0x0025808C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCharMaterialControllerFloatGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400DDB2 RID: 56754
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCharMaterialControllerFloatGroup";

		// Token: 0x0400DDB3 RID: 56755
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DDB4 RID: 56756
		internal static int __PropertyOffset_Start;

		// Token: 0x0400DDB5 RID: 56757
		[Nullable(2)]
		private FKuroCurveFloat _Start;

		// Token: 0x0400DDB6 RID: 56758
		internal static int __PropertyOffset_Loop;

		// Token: 0x0400DDB7 RID: 56759
		[Nullable(2)]
		private FKuroCurveFloat _Loop;

		// Token: 0x0400DDB8 RID: 56760
		internal static int __PropertyOffset_End;

		// Token: 0x0400DDB9 RID: 56761
		[Nullable(2)]
		private FKuroCurveFloat _End;
	}
}
