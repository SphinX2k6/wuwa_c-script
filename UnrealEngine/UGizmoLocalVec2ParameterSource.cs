using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200155D RID: 5469
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoLocalVec2ParameterSource")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UGizmoLocalVec2ParameterSource : UGizmoBaseVec2ParameterSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013D15 RID: 81173 RVA: 0x001D1969 File Offset: 0x001CFB69
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoLocalVec2ParameterSource._ClassPtr;
		}

		// Token: 0x06013D16 RID: 81174 RVA: 0x001D1978 File Offset: 0x001CFB78
		public UGizmoLocalVec2ParameterSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoLocalVec2ParameterSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013D17 RID: 81175 RVA: 0x001D19A0 File Offset: 0x001CFBA0
		public UGizmoLocalVec2ParameterSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoLocalVec2ParameterSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D9E RID: 19870
		// (get) Token: 0x06013D18 RID: 81176 RVA: 0x001D19D3 File Offset: 0x001CFBD3
		// (set) Token: 0x06013D19 RID: 81177 RVA: 0x001D19E7 File Offset: 0x001CFBE7
		public unsafe FVector2D Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoLocalVec2ParameterSource.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoLocalVec2ParameterSource.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17004D9F RID: 19871
		// (get) Token: 0x06013D1A RID: 81178 RVA: 0x001D19FC File Offset: 0x001CFBFC
		// (set) Token: 0x06013D1B RID: 81179 RVA: 0x001D1A35 File Offset: 0x001CFC35
		public FGizmoVec2ParameterChange LastChange
		{
			get
			{
				base.FastCheckIsValid();
				FGizmoVec2ParameterChange result;
				if ((result = this._LastChange) == null)
				{
					result = (this._LastChange = new FGizmoVec2ParameterChange(base.NativePtr + (IntPtr)UGizmoLocalVec2ParameterSource.__PropertyOffset_LastChange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGizmoVec2ParameterChange.StaticStruct(), base.NativePtr + (IntPtr)UGizmoLocalVec2ParameterSource.__PropertyOffset_LastChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06013D1C RID: 81180 RVA: 0x001D1A56 File Offset: 0x001CFC56
		static UGizmoLocalVec2ParameterSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoLocalVec2ParameterSource");
		}

		// Token: 0x06013D1D RID: 81181 RVA: 0x001D1A64 File Offset: 0x001CFC64
		protected UGizmoLocalVec2ParameterSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB89 RID: 43913
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoLocalVec2ParameterSource";

		// Token: 0x0400AB8A RID: 43914
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB8B RID: 43915
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AB8C RID: 43916
		internal static int __PropertyOffset_Value;

		// Token: 0x0400AB8D RID: 43917
		internal static int __PropertyOffset_LastChange;

		// Token: 0x0400AB8E RID: 43918
		[Nullable(2)]
		private FGizmoVec2ParameterChange _LastChange;
	}
}
