using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DD1 RID: 3537
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionGIReplace")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class UMaterialExpressionGIReplace : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BFBD RID: 49085 RVA: 0x00113206 File Offset: 0x00111406
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionGIReplace._ClassPtr;
		}

		// Token: 0x0600BFBE RID: 49086 RVA: 0x00113214 File Offset: 0x00111414
		public UMaterialExpressionGIReplace() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionGIReplace.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BFBF RID: 49087 RVA: 0x0011323C File Offset: 0x0011143C
		public UMaterialExpressionGIReplace(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionGIReplace.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C76 RID: 11382
		// (get) Token: 0x0600BFC0 RID: 49088 RVA: 0x00113270 File Offset: 0x00111470
		// (set) Token: 0x0600BFC1 RID: 49089 RVA: 0x001132A9 File Offset: 0x001114A9
		public FExpressionInput Default
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Default) == null)
				{
					result = (this._Default = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionGIReplace.__PropertyOffset_Default, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionGIReplace.__PropertyOffset_Default, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C77 RID: 11383
		// (get) Token: 0x0600BFC2 RID: 49090 RVA: 0x001132CC File Offset: 0x001114CC
		// (set) Token: 0x0600BFC3 RID: 49091 RVA: 0x00113305 File Offset: 0x00111505
		public FExpressionInput StaticIndirect
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._StaticIndirect) == null)
				{
					result = (this._StaticIndirect = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionGIReplace.__PropertyOffset_StaticIndirect, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionGIReplace.__PropertyOffset_StaticIndirect, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C78 RID: 11384
		// (get) Token: 0x0600BFC4 RID: 49092 RVA: 0x00113328 File Offset: 0x00111528
		// (set) Token: 0x0600BFC5 RID: 49093 RVA: 0x00113361 File Offset: 0x00111561
		public FExpressionInput DynamicIndirect
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._DynamicIndirect) == null)
				{
					result = (this._DynamicIndirect = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionGIReplace.__PropertyOffset_DynamicIndirect, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionGIReplace.__PropertyOffset_DynamicIndirect, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BFC6 RID: 49094 RVA: 0x00113382 File Offset: 0x00111582
		static UMaterialExpressionGIReplace()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionGIReplace");
		}

		// Token: 0x0600BFC7 RID: 49095 RVA: 0x00113390 File Offset: 0x00111590
		protected UMaterialExpressionGIReplace(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006590 RID: 26000
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionGIReplace";

		// Token: 0x04006591 RID: 26001
		private static IntPtr _ClassPtr;

		// Token: 0x04006592 RID: 26002
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006593 RID: 26003
		internal static int __PropertyOffset_Default;

		// Token: 0x04006594 RID: 26004
		[Nullable(2)]
		private FExpressionInput _Default;

		// Token: 0x04006595 RID: 26005
		internal static int __PropertyOffset_StaticIndirect;

		// Token: 0x04006596 RID: 26006
		[Nullable(2)]
		private FExpressionInput _StaticIndirect;

		// Token: 0x04006597 RID: 26007
		internal static int __PropertyOffset_DynamicIndirect;

		// Token: 0x04006598 RID: 26008
		[Nullable(2)]
		private FExpressionInput _DynamicIndirect;
	}
}
