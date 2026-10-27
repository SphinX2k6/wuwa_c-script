using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200155C RID: 5468
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoLocalFloatParameterSource")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UGizmoLocalFloatParameterSource : UGizmoBaseFloatParameterSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013D0C RID: 81164 RVA: 0x001D1870 File Offset: 0x001CFA70
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoLocalFloatParameterSource._ClassPtr;
		}

		// Token: 0x06013D0D RID: 81165 RVA: 0x001D187C File Offset: 0x001CFA7C
		public UGizmoLocalFloatParameterSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoLocalFloatParameterSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013D0E RID: 81166 RVA: 0x001D18A4 File Offset: 0x001CFAA4
		public UGizmoLocalFloatParameterSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoLocalFloatParameterSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D9C RID: 19868
		// (get) Token: 0x06013D0F RID: 81167 RVA: 0x001D18D7 File Offset: 0x001CFAD7
		// (set) Token: 0x06013D10 RID: 81168 RVA: 0x001D18E7 File Offset: 0x001CFAE7
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoLocalFloatParameterSource.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoLocalFloatParameterSource.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17004D9D RID: 19869
		// (get) Token: 0x06013D11 RID: 81169 RVA: 0x001D18F8 File Offset: 0x001CFAF8
		// (set) Token: 0x06013D12 RID: 81170 RVA: 0x001D1931 File Offset: 0x001CFB31
		public FGizmoFloatParameterChange LastChange
		{
			get
			{
				base.FastCheckIsValid();
				FGizmoFloatParameterChange result;
				if ((result = this._LastChange) == null)
				{
					result = (this._LastChange = new FGizmoFloatParameterChange(base.NativePtr + (IntPtr)UGizmoLocalFloatParameterSource.__PropertyOffset_LastChange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGizmoFloatParameterChange.StaticStruct(), base.NativePtr + (IntPtr)UGizmoLocalFloatParameterSource.__PropertyOffset_LastChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06013D13 RID: 81171 RVA: 0x001D1952 File Offset: 0x001CFB52
		static UGizmoLocalFloatParameterSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoLocalFloatParameterSource");
		}

		// Token: 0x06013D14 RID: 81172 RVA: 0x001D1960 File Offset: 0x001CFB60
		protected UGizmoLocalFloatParameterSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB83 RID: 43907
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoLocalFloatParameterSource";

		// Token: 0x0400AB84 RID: 43908
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB85 RID: 43909
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AB86 RID: 43910
		internal static int __PropertyOffset_Value;

		// Token: 0x0400AB87 RID: 43911
		internal static int __PropertyOffset_LastChange;

		// Token: 0x0400AB88 RID: 43912
		[Nullable(2)]
		private FGizmoFloatParameterChange _LastChange;
	}
}
