using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007C2 RID: 1986
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/RoadNetNavigationRuntime.RoadNetNavigationPath")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class URoadNetNavigationPath : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600ABDA RID: 43994 RVA: 0x000FD76E File Offset: 0x000FB96E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URoadNetNavigationPath._ClassPtr;
		}

		// Token: 0x0600ABDB RID: 43995 RVA: 0x000FD77C File Offset: 0x000FB97C
		public URoadNetNavigationPath() : this(BuiltinUtils.AllocNativeUObject(URoadNetNavigationPath.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ABDC RID: 43996 RVA: 0x000FD7A4 File Offset: 0x000FB9A4
		public URoadNetNavigationPath(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URoadNetNavigationPath.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x0600ABDD RID: 43997 RVA: 0x000FD7D8 File Offset: 0x000FB9D8
		// (set) Token: 0x0600ABDE RID: 43998 RVA: 0x000FD811 File Offset: 0x000FBA11
		public TArray<FVector> PathPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PathPoints) == null)
				{
					result = (this._PathPoints = new TArray<FVector>(base.NativePtr + (IntPtr)URoadNetNavigationPath.__PropertyOffset_PathPoints, this));
				}
				return result;
			}
			set
			{
				this.PathPoints.CopyAssign(value);
			}
		}

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x0600ABDF RID: 43999 RVA: 0x000FD81F File Offset: 0x000FBA1F
		// (set) Token: 0x0600ABE0 RID: 44000 RVA: 0x000FD82F File Offset: 0x000FBA2F
		public unsafe float Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URoadNetNavigationPath.__PropertyOffset_Length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URoadNetNavigationPath.__PropertyOffset_Length) = value;
			}
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x0600ABE1 RID: 44001 RVA: 0x000FD840 File Offset: 0x000FBA40
		// (set) Token: 0x0600ABE2 RID: 44002 RVA: 0x000FD850 File Offset: 0x000FBA50
		public unsafe bool IsPartial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URoadNetNavigationPath.__PropertyOffset_IsPartial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URoadNetNavigationPath.__PropertyOffset_IsPartial) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600ABE3 RID: 44003 RVA: 0x000FD861 File Offset: 0x000FBA61
		static URoadNetNavigationPath()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/RoadNetNavigationRuntime.RoadNetNavigationPath");
		}

		// Token: 0x0600ABE4 RID: 44004 RVA: 0x000FD86F File Offset: 0x000FBA6F
		protected URoadNetNavigationPath(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040049E5 RID: 18917
		public new const string __ObjectPath = "/Script/RoadNetNavigationRuntime.RoadNetNavigationPath";

		// Token: 0x040049E6 RID: 18918
		private static IntPtr _ClassPtr;

		// Token: 0x040049E7 RID: 18919
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040049E8 RID: 18920
		internal static int __PropertyOffset_PathPoints;

		// Token: 0x040049E9 RID: 18921
		[Nullable(2)]
		private TArray<FVector> _PathPoints;

		// Token: 0x040049EA RID: 18922
		internal static int __PropertyOffset_Length;

		// Token: 0x040049EB RID: 18923
		internal static int __PropertyOffset_IsPartial;
	}
}
