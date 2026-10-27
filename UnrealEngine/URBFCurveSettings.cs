using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001069 RID: 4201
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RBFCurveSettings")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class URBFCurveSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600EF08 RID: 61192 RVA: 0x00162861 File Offset: 0x00160A61
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URBFCurveSettings._ClassPtr;
		}

		// Token: 0x0600EF09 RID: 61193 RVA: 0x00162870 File Offset: 0x00160A70
		public URBFCurveSettings() : this(BuiltinUtils.AllocNativeUObject(URBFCurveSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600EF0A RID: 61194 RVA: 0x00162898 File Offset: 0x00160A98
		public URBFCurveSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URBFCurveSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039D9 RID: 14809
		// (get) Token: 0x0600EF0B RID: 61195 RVA: 0x001628CC File Offset: 0x00160ACC
		// (set) Token: 0x0600EF0C RID: 61196 RVA: 0x00162905 File Offset: 0x00160B05
		public TArray<string> RBFCurveNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._RBFCurveNames) == null)
				{
					result = (this._RBFCurveNames = new TArray<string>(base.NativePtr + (IntPtr)URBFCurveSettings.__PropertyOffset_RBFCurveNames, this));
				}
				return result;
			}
			set
			{
				this.RBFCurveNames.CopyAssign(value);
			}
		}

		// Token: 0x0600EF0D RID: 61197 RVA: 0x00162913 File Offset: 0x00160B13
		static URBFCurveSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RBFCurveSettings");
		}

		// Token: 0x0600EF0E RID: 61198 RVA: 0x00162921 File Offset: 0x00160B21
		protected URBFCurveSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008159 RID: 33113
		public new const string __ObjectPath = "/Script/Engine.RBFCurveSettings";

		// Token: 0x0400815A RID: 33114
		private static IntPtr _ClassPtr;

		// Token: 0x0400815B RID: 33115
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400815C RID: 33116
		internal static int __PropertyOffset_RBFCurveNames;

		// Token: 0x0400815D RID: 33117
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _RBFCurveNames;
	}
}
