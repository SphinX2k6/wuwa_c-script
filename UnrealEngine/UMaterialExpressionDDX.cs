using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DAD RID: 3501
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDDX")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionDDX : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE77 RID: 48759 RVA: 0x00110C71 File Offset: 0x0010EE71
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDDX._ClassPtr;
		}

		// Token: 0x0600BE78 RID: 48760 RVA: 0x00110C80 File Offset: 0x0010EE80
		public UMaterialExpressionDDX() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDDX.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE79 RID: 48761 RVA: 0x00110CA8 File Offset: 0x0010EEA8
		public UMaterialExpressionDDX(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDDX.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C2D RID: 11309
		// (get) Token: 0x0600BE7A RID: 48762 RVA: 0x00110CDC File Offset: 0x0010EEDC
		// (set) Token: 0x0600BE7B RID: 48763 RVA: 0x00110D15 File Offset: 0x0010EF15
		public FExpressionInput Value
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDDX.__PropertyOffset_Value, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDDX.__PropertyOffset_Value, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BE7C RID: 48764 RVA: 0x00110D36 File Offset: 0x0010EF36
		static UMaterialExpressionDDX()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDDX");
		}

		// Token: 0x0600BE7D RID: 48765 RVA: 0x00110D44 File Offset: 0x0010EF44
		protected UMaterialExpressionDDX(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064AF RID: 25775
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDDX";

		// Token: 0x040064B0 RID: 25776
		private static IntPtr _ClassPtr;

		// Token: 0x040064B1 RID: 25777
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040064B2 RID: 25778
		internal static int __PropertyOffset_Value;

		// Token: 0x040064B3 RID: 25779
		[Nullable(2)]
		private FExpressionInput _Value;
	}
}
