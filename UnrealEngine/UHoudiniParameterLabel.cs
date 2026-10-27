using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014F2 RID: 5362
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterLabel")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UHoudiniParameterLabel : UHoudiniParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060136EF RID: 79599 RVA: 0x001C91F8 File Offset: 0x001C73F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterLabel._ClassPtr;
		}

		// Token: 0x060136F0 RID: 79600 RVA: 0x001C9204 File Offset: 0x001C7404
		public UHoudiniParameterLabel() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterLabel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060136F1 RID: 79601 RVA: 0x001C922C File Offset: 0x001C742C
		public UHoudiniParameterLabel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterLabel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BE6 RID: 19430
		// (get) Token: 0x060136F2 RID: 79602 RVA: 0x001C9260 File Offset: 0x001C7460
		// (set) Token: 0x060136F3 RID: 79603 RVA: 0x001C9299 File Offset: 0x001C7499
		public TArray<string> LabelStrings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._LabelStrings) == null)
				{
					result = (this._LabelStrings = new TArray<string>(base.NativePtr + (IntPtr)UHoudiniParameterLabel.__PropertyOffset_LabelStrings, this));
				}
				return result;
			}
			set
			{
				this.LabelStrings.CopyAssign(value);
			}
		}

		// Token: 0x060136F4 RID: 79604 RVA: 0x001C92A7 File Offset: 0x001C74A7
		static UHoudiniParameterLabel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterLabel");
		}

		// Token: 0x060136F5 RID: 79605 RVA: 0x001C92B5 File Offset: 0x001C74B5
		protected UHoudiniParameterLabel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A807 RID: 43015
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterLabel";

		// Token: 0x0400A808 RID: 43016
		private static IntPtr _ClassPtr;

		// Token: 0x0400A809 RID: 43017
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A80A RID: 43018
		internal static int __PropertyOffset_LabelStrings;

		// Token: 0x0400A80B RID: 43019
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _LabelStrings;
	}
}
