using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DFC RID: 3580
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionNamedRerouteDeclaration")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UMaterialExpressionNamedRerouteDeclaration : UMaterialExpressionNamedRerouteBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C19B RID: 49563 RVA: 0x00116ED1 File Offset: 0x001150D1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionNamedRerouteDeclaration._ClassPtr;
		}

		// Token: 0x0600C19C RID: 49564 RVA: 0x00116EE0 File Offset: 0x001150E0
		public UMaterialExpressionNamedRerouteDeclaration() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionNamedRerouteDeclaration.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C19D RID: 49565 RVA: 0x00116F08 File Offset: 0x00115108
		public UMaterialExpressionNamedRerouteDeclaration(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionNamedRerouteDeclaration.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CFA RID: 11514
		// (get) Token: 0x0600C19E RID: 49566 RVA: 0x00116F3C File Offset: 0x0011513C
		// (set) Token: 0x0600C19F RID: 49567 RVA: 0x00116F75 File Offset: 0x00115175
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionNamedRerouteDeclaration.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionNamedRerouteDeclaration.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CFB RID: 11515
		// (get) Token: 0x0600C1A0 RID: 49568 RVA: 0x00116F96 File Offset: 0x00115196
		// (set) Token: 0x0600C1A1 RID: 49569 RVA: 0x00116FAA File Offset: 0x001151AA
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionNamedRerouteDeclaration.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionNamedRerouteDeclaration.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17002CFC RID: 11516
		// (get) Token: 0x0600C1A2 RID: 49570 RVA: 0x00116FBF File Offset: 0x001151BF
		// (set) Token: 0x0600C1A3 RID: 49571 RVA: 0x00116FD3 File Offset: 0x001151D3
		public unsafe FGuid VariableGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionNamedRerouteDeclaration.__PropertyOffset_VariableGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionNamedRerouteDeclaration.__PropertyOffset_VariableGuid) = value;
			}
		}

		// Token: 0x0600C1A4 RID: 49572 RVA: 0x00116FE8 File Offset: 0x001151E8
		static UMaterialExpressionNamedRerouteDeclaration()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionNamedRerouteDeclaration");
		}

		// Token: 0x0600C1A5 RID: 49573 RVA: 0x00116FF6 File Offset: 0x001151F6
		protected UMaterialExpressionNamedRerouteDeclaration(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040066F7 RID: 26359
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionNamedRerouteDeclaration";

		// Token: 0x040066F8 RID: 26360
		private static IntPtr _ClassPtr;

		// Token: 0x040066F9 RID: 26361
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040066FA RID: 26362
		internal static int __PropertyOffset_Input;

		// Token: 0x040066FB RID: 26363
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x040066FC RID: 26364
		internal static int __PropertyOffset_Name;

		// Token: 0x040066FD RID: 26365
		internal static int __PropertyOffset_VariableGuid;
	}
}
