using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000400 RID: 1024
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroSceneTeamItem")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FKuroSceneTeamItem : IEqualityOperators<FKuroSceneTeamItem, FKuroSceneTeamItem, bool>, IEquatable<FKuroSceneTeamItem>, IUnrealScriptStruct
	{
		// Token: 0x06006463 RID: 25699 RVA: 0x0008F692 File Offset: 0x0008D892
		public FKuroSceneTeamItem(int EntityId, bool IsMyRole)
		{
			this.EntityId = EntityId;
			this.IsMyRole = IsMyRole;
		}

		// Token: 0x06006464 RID: 25700 RVA: 0x0008F6A2 File Offset: 0x0008D8A2
		public static bool operator ==(FKuroSceneTeamItem left, FKuroSceneTeamItem right)
		{
			return left.EntityId == right.EntityId && left.IsMyRole == right.IsMyRole;
		}

		// Token: 0x06006465 RID: 25701 RVA: 0x0008F6C2 File Offset: 0x0008D8C2
		public static bool operator !=(FKuroSceneTeamItem left, FKuroSceneTeamItem right)
		{
			return !(left == right);
		}

		// Token: 0x06006466 RID: 25702 RVA: 0x0008F6CE File Offset: 0x0008D8CE
		public bool Equals(FKuroSceneTeamItem other)
		{
			return this == other;
		}

		// Token: 0x06006467 RID: 25703 RVA: 0x0008F6DC File Offset: 0x0008D8DC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FKuroSceneTeamItem)
			{
				FKuroSceneTeamItem other = (FKuroSceneTeamItem)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06006468 RID: 25704 RVA: 0x0008F701 File Offset: 0x0008D901
		public override int GetHashCode()
		{
			return HashCode.Combine<int, bool>(this.EntityId, this.IsMyRole);
		}

		// Token: 0x06006469 RID: 25705 RVA: 0x0008F714 File Offset: 0x0008D914
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSceneTeamItem._ScriptStructPtr != 0) ? FKuroSceneTeamItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroSceneTeamItem", ref FKuroSceneTeamItem._ScriptStructPtr);
		}

		// Token: 0x04002A5E RID: 10846
		[FieldOffset(0)]
		public int EntityId;

		// Token: 0x04002A5F RID: 10847
		[FieldOffset(4)]
		public bool IsMyRole;

		// Token: 0x04002A60 RID: 10848
		public const string __ObjectPath = "/Script/KuroGameplay.KuroSceneTeamItem";

		// Token: 0x04002A61 RID: 10849
		private static IntPtr _ScriptStructPtr;
	}
}
