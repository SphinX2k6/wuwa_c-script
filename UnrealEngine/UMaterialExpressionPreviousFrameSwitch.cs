using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E20 RID: 3616
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionPreviousFrameSwitch")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionPreviousFrameSwitch : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C29D RID: 49821 RVA: 0x0011897A File Offset: 0x00116B7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionPreviousFrameSwitch._ClassPtr;
		}

		// Token: 0x0600C29E RID: 49822 RVA: 0x00118988 File Offset: 0x00116B88
		public UMaterialExpressionPreviousFrameSwitch() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPreviousFrameSwitch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C29F RID: 49823 RVA: 0x001189B0 File Offset: 0x00116BB0
		public UMaterialExpressionPreviousFrameSwitch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPreviousFrameSwitch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D21 RID: 11553
		// (get) Token: 0x0600C2A0 RID: 49824 RVA: 0x001189E4 File Offset: 0x00116BE4
		// (set) Token: 0x0600C2A1 RID: 49825 RVA: 0x00118A1D File Offset: 0x00116C1D
		public FExpressionInput CurrentFrame
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._CurrentFrame) == null)
				{
					result = (this._CurrentFrame = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionPreviousFrameSwitch.__PropertyOffset_CurrentFrame, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionPreviousFrameSwitch.__PropertyOffset_CurrentFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D22 RID: 11554
		// (get) Token: 0x0600C2A2 RID: 49826 RVA: 0x00118A40 File Offset: 0x00116C40
		// (set) Token: 0x0600C2A3 RID: 49827 RVA: 0x00118A79 File Offset: 0x00116C79
		public FExpressionInput PreviousFrame
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._PreviousFrame) == null)
				{
					result = (this._PreviousFrame = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionPreviousFrameSwitch.__PropertyOffset_PreviousFrame, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionPreviousFrameSwitch.__PropertyOffset_PreviousFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C2A4 RID: 49828 RVA: 0x00118A9A File Offset: 0x00116C9A
		static UMaterialExpressionPreviousFrameSwitch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionPreviousFrameSwitch");
		}

		// Token: 0x0600C2A5 RID: 49829 RVA: 0x00118AA8 File Offset: 0x00116CA8
		protected UMaterialExpressionPreviousFrameSwitch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400679A RID: 26522
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionPreviousFrameSwitch";

		// Token: 0x0400679B RID: 26523
		private static IntPtr _ClassPtr;

		// Token: 0x0400679C RID: 26524
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400679D RID: 26525
		internal static int __PropertyOffset_CurrentFrame;

		// Token: 0x0400679E RID: 26526
		[Nullable(2)]
		private FExpressionInput _CurrentFrame;

		// Token: 0x0400679F RID: 26527
		internal static int __PropertyOffset_PreviousFrame;

		// Token: 0x040067A0 RID: 26528
		[Nullable(2)]
		private FExpressionInput _PreviousFrame;
	}
}
