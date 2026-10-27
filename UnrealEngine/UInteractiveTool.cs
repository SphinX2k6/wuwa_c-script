using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001576 RID: 5494
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InteractiveTool")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UInteractiveTool : UObject, IUnrealUObject, IUnrealObject, IInputBehaviorSource, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013DFE RID: 81406 RVA: 0x001D2F32 File Offset: 0x001D1132
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInteractiveTool._ClassPtr;
		}

		// Token: 0x06013DFF RID: 81407 RVA: 0x001D2F3E File Offset: 0x001D113E
		int IInputBehaviorSource.InterfaceOffset()
		{
			return UInteractiveTool.__InterfaceOffset_IInputBehaviorSource;
		}

		// Token: 0x06013E00 RID: 81408 RVA: 0x001D2F48 File Offset: 0x001D1148
		public UInteractiveTool() : this(BuiltinUtils.AllocNativeUObject(UInteractiveTool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E01 RID: 81409 RVA: 0x001D2F70 File Offset: 0x001D1170
		[NullableContext(1)]
		public UInteractiveTool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInteractiveTool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DD3 RID: 19923
		// (get) Token: 0x06013E02 RID: 81410 RVA: 0x001D2FA3 File Offset: 0x001D11A3
		// (set) Token: 0x06013E03 RID: 81411 RVA: 0x001D2FB7 File Offset: 0x001D11B7
		[Nullable(2)]
		public unsafe UInputBehaviorSet InputBehaviors
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInputBehaviorSet>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveTool.__PropertyOffset_InputBehaviors);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveTool.__PropertyOffset_InputBehaviors, value);
			}
		}

		// Token: 0x17004DD4 RID: 19924
		// (get) Token: 0x06013E04 RID: 81412 RVA: 0x001D2FCC File Offset: 0x001D11CC
		// (set) Token: 0x06013E05 RID: 81413 RVA: 0x001D3005 File Offset: 0x001D1205
		[Nullable(1)]
		public TArray<UObject> ToolPropertyObjects
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ToolPropertyObjects) == null)
				{
					result = (this._ToolPropertyObjects = new TArray<UObject>(base.NativePtr + (IntPtr)UInteractiveTool.__PropertyOffset_ToolPropertyObjects, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ToolPropertyObjects.CopyAssign(value);
			}
		}

		// Token: 0x06013E06 RID: 81414 RVA: 0x001D3013 File Offset: 0x001D1213
		static UInteractiveTool()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.InteractiveTool");
		}

		// Token: 0x06013E07 RID: 81415 RVA: 0x001D3021 File Offset: 0x001D1221
		protected UInteractiveTool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC0C RID: 44044
		internal static int __InterfaceOffset_IInputBehaviorSource;

		// Token: 0x0400AC0D RID: 44045
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.InteractiveTool";

		// Token: 0x0400AC0E RID: 44046
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC0F RID: 44047
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AC10 RID: 44048
		internal static int __PropertyOffset_InputBehaviors;

		// Token: 0x0400AC11 RID: 44049
		internal static int __PropertyOffset_ToolPropertyObjects;

		// Token: 0x0400AC12 RID: 44050
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ToolPropertyObjects;
	}
}
