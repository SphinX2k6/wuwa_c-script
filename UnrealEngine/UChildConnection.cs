using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000932 RID: 2354
	[UnrealObjectPath("/Script/Engine.ChildConnection")]
	[UnrealStructLayout(7040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 7040)]
	public class UChildConnection : UNetConnection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600850A RID: 34058 RVA: 0x000BDBE8 File Offset: 0x000BBDE8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UChildConnection._ClassPtr;
		}

		// Token: 0x0600850B RID: 34059 RVA: 0x000BDBF4 File Offset: 0x000BBDF4
		public UChildConnection() : this(BuiltinUtils.AllocNativeUObject(UChildConnection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600850C RID: 34060 RVA: 0x000BDC1C File Offset: 0x000BBE1C
		[NullableContext(1)]
		public UChildConnection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UChildConnection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x0600850D RID: 34061 RVA: 0x000BDC4F File Offset: 0x000BBE4F
		// (set) Token: 0x0600850E RID: 34062 RVA: 0x000BDC63 File Offset: 0x000BBE63
		[Nullable(2)]
		public unsafe UNetConnection Parent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNetConnection>(base.NativePtr / (IntPtr)sizeof(void*) + UChildConnection.__PropertyOffset_Parent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UChildConnection.__PropertyOffset_Parent, value);
			}
		}

		// Token: 0x0600850F RID: 34063 RVA: 0x000BDC78 File Offset: 0x000BBE78
		static UChildConnection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ChildConnection");
		}

		// Token: 0x06008510 RID: 34064 RVA: 0x000BDC86 File Offset: 0x000BBE86
		protected UChildConnection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003F4F RID: 16207
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ChildConnection";

		// Token: 0x04003F50 RID: 16208
		private static IntPtr _ClassPtr;

		// Token: 0x04003F51 RID: 16209
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003F52 RID: 16210
		internal static int __PropertyOffset_Parent;
	}
}
