using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E3F RID: 3647
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionShadowReplace")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionShadowReplace : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C3DB RID: 50139 RVA: 0x0011AEDF File Offset: 0x001190DF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionShadowReplace._ClassPtr;
		}

		// Token: 0x0600C3DC RID: 50140 RVA: 0x0011AEEC File Offset: 0x001190EC
		public UMaterialExpressionShadowReplace() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionShadowReplace.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C3DD RID: 50141 RVA: 0x0011AF14 File Offset: 0x00119114
		public UMaterialExpressionShadowReplace(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionShadowReplace.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D73 RID: 11635
		// (get) Token: 0x0600C3DE RID: 50142 RVA: 0x0011AF48 File Offset: 0x00119148
		// (set) Token: 0x0600C3DF RID: 50143 RVA: 0x0011AF81 File Offset: 0x00119181
		public FExpressionInput Default
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Default) == null)
				{
					result = (this._Default = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionShadowReplace.__PropertyOffset_Default, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionShadowReplace.__PropertyOffset_Default, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D74 RID: 11636
		// (get) Token: 0x0600C3E0 RID: 50144 RVA: 0x0011AFA4 File Offset: 0x001191A4
		// (set) Token: 0x0600C3E1 RID: 50145 RVA: 0x0011AFDD File Offset: 0x001191DD
		public FExpressionInput Shadow
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Shadow) == null)
				{
					result = (this._Shadow = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionShadowReplace.__PropertyOffset_Shadow, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionShadowReplace.__PropertyOffset_Shadow, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C3E2 RID: 50146 RVA: 0x0011AFFE File Offset: 0x001191FE
		static UMaterialExpressionShadowReplace()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionShadowReplace");
		}

		// Token: 0x0600C3E3 RID: 50147 RVA: 0x0011B00C File Offset: 0x0011920C
		protected UMaterialExpressionShadowReplace(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400687B RID: 26747
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionShadowReplace";

		// Token: 0x0400687C RID: 26748
		private static IntPtr _ClassPtr;

		// Token: 0x0400687D RID: 26749
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400687E RID: 26750
		internal static int __PropertyOffset_Default;

		// Token: 0x0400687F RID: 26751
		[Nullable(2)]
		private FExpressionInput _Default;

		// Token: 0x04006880 RID: 26752
		internal static int __PropertyOffset_Shadow;

		// Token: 0x04006881 RID: 26753
		[Nullable(2)]
		private FExpressionInput _Shadow;
	}
}
