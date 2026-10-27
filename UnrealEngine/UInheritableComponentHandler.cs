using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C4C RID: 3148
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InheritableComponentHandler")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UInheritableComponentHandler : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009F9E RID: 40862 RVA: 0x000E2CF2 File Offset: 0x000E0EF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInheritableComponentHandler._ClassPtr;
		}

		// Token: 0x06009F9F RID: 40863 RVA: 0x000E2D00 File Offset: 0x000E0F00
		public UInheritableComponentHandler() : this(BuiltinUtils.AllocNativeUObject(UInheritableComponentHandler.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009FA0 RID: 40864 RVA: 0x000E2D28 File Offset: 0x000E0F28
		public UInheritableComponentHandler(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInheritableComponentHandler.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700260A RID: 9738
		// (get) Token: 0x06009FA1 RID: 40865 RVA: 0x000E2D5C File Offset: 0x000E0F5C
		// (set) Token: 0x06009FA2 RID: 40866 RVA: 0x000E2D95 File Offset: 0x000E0F95
		public TArray<FComponentOverrideRecord> Records
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FComponentOverrideRecord> result;
				if ((result = this._Records) == null)
				{
					result = (this._Records = new TArray<FComponentOverrideRecord>(base.NativePtr + (IntPtr)UInheritableComponentHandler.__PropertyOffset_Records, this));
				}
				return result;
			}
			set
			{
				this.Records.CopyAssign(value);
			}
		}

		// Token: 0x1700260B RID: 9739
		// (get) Token: 0x06009FA3 RID: 40867 RVA: 0x000E2DA4 File Offset: 0x000E0FA4
		// (set) Token: 0x06009FA4 RID: 40868 RVA: 0x000E2DDD File Offset: 0x000E0FDD
		public TArray<UActorComponent> UnnecessaryComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UActorComponent> result;
				if ((result = this._UnnecessaryComponents) == null)
				{
					result = (this._UnnecessaryComponents = new TArray<UActorComponent>(base.NativePtr + (IntPtr)UInheritableComponentHandler.__PropertyOffset_UnnecessaryComponents, this));
				}
				return result;
			}
			set
			{
				this.UnnecessaryComponents.CopyAssign(value);
			}
		}

		// Token: 0x06009FA5 RID: 40869 RVA: 0x000E2DEB File Offset: 0x000E0FEB
		static UInheritableComponentHandler()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InheritableComponentHandler");
		}

		// Token: 0x06009FA6 RID: 40870 RVA: 0x000E2DF9 File Offset: 0x000E0FF9
		protected UInheritableComponentHandler(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040057D5 RID: 22485
		public new const string __ObjectPath = "/Script/Engine.InheritableComponentHandler";

		// Token: 0x040057D6 RID: 22486
		private static IntPtr _ClassPtr;

		// Token: 0x040057D7 RID: 22487
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040057D8 RID: 22488
		internal static int __PropertyOffset_Records;

		// Token: 0x040057D9 RID: 22489
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FComponentOverrideRecord> _Records;

		// Token: 0x040057DA RID: 22490
		internal static int __PropertyOffset_UnnecessaryComponents;

		// Token: 0x040057DB RID: 22491
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _UnnecessaryComponents;
	}
}
