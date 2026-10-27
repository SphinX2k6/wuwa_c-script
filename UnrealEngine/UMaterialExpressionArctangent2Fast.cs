using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D8A RID: 3466
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionArctangent2Fast")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionArctangent2Fast : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD38 RID: 48440 RVA: 0x0010E92D File Offset: 0x0010CB2D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionArctangent2Fast._ClassPtr;
		}

		// Token: 0x0600BD39 RID: 48441 RVA: 0x0010E93C File Offset: 0x0010CB3C
		public UMaterialExpressionArctangent2Fast() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionArctangent2Fast.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD3A RID: 48442 RVA: 0x0010E964 File Offset: 0x0010CB64
		public UMaterialExpressionArctangent2Fast(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionArctangent2Fast.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BE4 RID: 11236
		// (get) Token: 0x0600BD3B RID: 48443 RVA: 0x0010E998 File Offset: 0x0010CB98
		// (set) Token: 0x0600BD3C RID: 48444 RVA: 0x0010E9D1 File Offset: 0x0010CBD1
		public FExpressionInput Y
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Y) == null)
				{
					result = (this._Y = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionArctangent2Fast.__PropertyOffset_Y, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionArctangent2Fast.__PropertyOffset_Y, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002BE5 RID: 11237
		// (get) Token: 0x0600BD3D RID: 48445 RVA: 0x0010E9F4 File Offset: 0x0010CBF4
		// (set) Token: 0x0600BD3E RID: 48446 RVA: 0x0010EA2D File Offset: 0x0010CC2D
		public FExpressionInput X
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._X) == null)
				{
					result = (this._X = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionArctangent2Fast.__PropertyOffset_X, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionArctangent2Fast.__PropertyOffset_X, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BD3F RID: 48447 RVA: 0x0010EA4E File Offset: 0x0010CC4E
		static UMaterialExpressionArctangent2Fast()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionArctangent2Fast");
		}

		// Token: 0x0600BD40 RID: 48448 RVA: 0x0010EA5C File Offset: 0x0010CC5C
		protected UMaterialExpressionArctangent2Fast(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063D5 RID: 25557
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionArctangent2Fast";

		// Token: 0x040063D6 RID: 25558
		private static IntPtr _ClassPtr;

		// Token: 0x040063D7 RID: 25559
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040063D8 RID: 25560
		internal static int __PropertyOffset_Y;

		// Token: 0x040063D9 RID: 25561
		[Nullable(2)]
		private FExpressionInput _Y;

		// Token: 0x040063DA RID: 25562
		internal static int __PropertyOffset_X;

		// Token: 0x040063DB RID: 25563
		[Nullable(2)]
		private FExpressionInput _X;
	}
}
